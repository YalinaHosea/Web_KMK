using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Web_KMK.Models;
using Dapper;
using System;

namespace Web_KMK.DAL {

    public class RenunganDAL : IRenungan
    {

         private IConfiguration _config;
        public RenunganDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public IEnumerable<Renungan> GetAll()
        {
             using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Renungan";
                return conn.Query<Renungan>(strSql);
            }
        }

        public Renungan GetById(int id_bacaan)
        {
             using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Renungan where id_bacaan=@id_bacaan";
                var param = new {id_bacaan=id_bacaan};
                var Data = conn.QuerySingleOrDefault<Renungan>(strSql,param);
                if(Data!=null)
                    return Data;
                    else
                    throw new Exception("Data tidak ditemukan !");
            }
        }

        public void Create(Renungan ren)
        {
           using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"insert into Renungan(judul,isi) values(@judul,@isi)";

                try{
                    var param = new {judul=ren.judul,isi=ren.isi};
                    conn.Execute(strSql,param); 

                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Renungan ren)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"update Renungan set judul=@judul, isi=@isi where id_bacaan=@id_bacaan";
                try{
                    var param = new {judul=ren.judul, isi=ren.isi,
                    id_bacaan=ren.id_bacaan};
                    conn.Execute(strSql,param);
                    }catch(SqlException sqlEx){
                        throw new Exception($"Error: {sqlEx.Message}");
                    }
                }
        }

        public void Delete(int id_bacaan)
        {
           using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"delete from Renungan where id_bacaan=@id_bacaan";
                try{
                    var param = new{id_bacaan=id_bacaan};
                    conn.Execute(strSql,param);
                }catch(SqlException sqlEx){
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }
    }
}