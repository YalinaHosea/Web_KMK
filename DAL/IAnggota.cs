

using System.Collections.Generic;
using Web_KMK.Models;

namespace Web_KMK.DAL{
    public interface IAnggota{
        IEnumerable<Anggota> GetAll();

        Anggota GetByid_anggota(string id_anggota);

        void Insert(Anggota agt);

        void Update(Anggota agt);
        void Delete(string nim);

    }
}