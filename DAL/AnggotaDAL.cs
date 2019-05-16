

using System.Collections.Generic;
using Web_KMK.Models;
using Dapper;
using System.Data.SqlClient;

namespace Web_KMK.DAL{
    public class AnggotaDAL : IAnggota
    {
        public void Delete(string nim)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Anggota> GetAll()
        {
            
        }

        public Anggota GetByid_anggota(string id_anggota)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Anggota agt)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Anggota agt)
        {
            throw new System.NotImplementedException();
        }
    }
}