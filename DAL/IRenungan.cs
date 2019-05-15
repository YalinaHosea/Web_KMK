using System.Collections.Generic;
using Web_KMK.Models;

namespace Web_KMK.DAL {
    public interface IRenungan
    {
        IEnumerable<Renungan> GetAll();
         Renungan GetById(int id_bacaan);

        void Create(Renungan ren);

        void Update(Renungan ren);

        void Delete(int id_bacaan);
        
    }

}