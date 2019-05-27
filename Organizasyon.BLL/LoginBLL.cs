using Organizasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizasyon.BLL
{
    public static class LoginBLL
    {
        static DataContext db = new DataContext();
       
        public static void KayıtEkle (Login login)
        {
            db.Login.Add(login);
            db.SaveChanges();
        }

        public static Login Uyeol(string username,string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new FieldAccessException("Lütfen boş bırakmayınız");
            }


            var uyeol = db.Login.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            return uyeol;
        }
    }
}
