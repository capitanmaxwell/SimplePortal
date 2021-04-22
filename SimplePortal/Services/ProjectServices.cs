using SimplePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePortal.Services
{
    public class ProjectServices
    {
        protected readonly ApplicationDbContext _dbcontext;
        public ProjectServices(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        #region games
        public List<Games> GetAllGames()
        {
            return _dbcontext.Games.ToList();
        }
        public bool InsertRecG(Games gadd)
        {
            _dbcontext.Games.Add(gadd);
            _dbcontext.SaveChanges();
            return true;
        }
        public Games EditRecG(int id)
        {
            Games gc = new Games();
            return _dbcontext.Games.FirstOrDefault(u => u.Id == id);
        }
        public bool UpdateRecG(Games gupdate)
        {
            var Grecupdate = _dbcontext.Games.FirstOrDefault(u => u.Id == gupdate.Id);
            if (Grecupdate != null)
            {
                Grecupdate.NameG = gupdate.NameG;
                //Grecupdate.DateRelease = gupdate.DateRelease;
                Grecupdate.Mode = gupdate.Mode;
                Grecupdate.About = gupdate.About;
                Grecupdate.OS = gupdate.OS;
                Grecupdate.Genre = gupdate.Genre;
                Grecupdate.Price = gupdate.Price;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool DeleteRecG(Games gdelete)
        {
            var Grecgdelete = _dbcontext.Games.FirstOrDefault(u => u.Id == gdelete.Id);
            if (Grecgdelete != null)
            {
                _dbcontext.Remove(Grecgdelete);
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        #endregion
        #region programs
        public List<Programs> GetAllPrograms()
        {
            return _dbcontext.Programs.ToList();
        }
        public bool InsertRecP(Programs padd)
        {
            _dbcontext.Programs.Add(padd);
            _dbcontext.SaveChanges();
            return true;
        }
        public Programs EditRecP(int id)
        {
            Programs pc = new Programs();
            return _dbcontext.Programs.FirstOrDefault(u => u.Id == id);
        }
        public bool UpdateRecP(Programs pupdate)
        {
            var Precupdate = _dbcontext.Programs.FirstOrDefault(u => u.Id == pupdate.Id);
            if (Precupdate != null)
            {
                Precupdate.NameP = pupdate.NameP;
                //Precupdate.DateRelease = pupdate.DateRelease;
                Precupdate.About = pupdate.About;
                Precupdate.OS = pupdate.OS;
                Precupdate.Price = pupdate.Price;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool DeleteRecP(Programs pdelete)
        {
            var Precgdelete = _dbcontext.Programs.FirstOrDefault(u => u.Id == pdelete.Id);
            if (Precgdelete != null)
            {
                _dbcontext.Remove(Precgdelete);
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        #endregion
        #region users
        public List<Users> GetAllUsers()
        {
            return _dbcontext.Users.ToList();
        }
        public bool InsertRecU(Users uadd)
        {
            _dbcontext.Users.Add(uadd);
            _dbcontext.SaveChanges();
            return true;
        }
        public Users EditRecU(int id)
        {
            Users pc = new Users();
            return _dbcontext.Users.FirstOrDefault(u => u.Id == id);
        }
        public bool UpdateRecU(Users uupdate)
        {
            var Precupdate = _dbcontext.Users.FirstOrDefault(u => u.Id == uupdate.Id);
            if (Precupdate != null)
            {
                Precupdate.Login = uupdate.Login;
                //Precupdate.DateRelease = pupdate.DateRelease;
                Precupdate.Password = uupdate.Password;
                Precupdate.Email = uupdate.Email;
                Precupdate.Balance = uupdate.Balance;
                Precupdate.Role = uupdate.Role;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool DeleteRecU(Users udelete)
        {
            var Precgdelete = _dbcontext.Users.FirstOrDefault(u => u.Id == udelete.Id);
            if (Precgdelete != null)
            {
                _dbcontext.Remove(Precgdelete);
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
