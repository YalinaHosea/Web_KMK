using System.Collections.Generic;
using Web_KMK.Models;

namespace Web_KMK.DAL {
    public interface IAdmin
    {
        IEnumerable<Admin> Login(string email, string password);
        
    }

}