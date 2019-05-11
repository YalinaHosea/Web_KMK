

using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Web_KMK.Models;
using Dapper;

namespace Web_KMK.DAL {

    public class AdminDAL : IAdmin
    {
        private IConfiguration _config;
        public AdminDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public IEnumerable<Admin> Login(string email, string password)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Admin where email=@email and password=@password";
                var param = new {email=email, password=password};
                return conn.Query<Admin>(strSql,param);   
            }
                     }
    }
}