using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Entity_DAL.MedelsDataBase;
using NLog;

namespace DB_Entity_DAL.DB_Operations
{
    public class DB_User
    {
        private OperationslogError nLog = new OperationslogError();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public string searchUser(string _login , string email , string phone) // check info who register user
        {
            try
            {
                using (Sell_BuyEntities db = new Sell_BuyEntities())
                {
                    StringBuilder ErrorMessage = new StringBuilder();
                    var  user = db.Users.FirstOrDefault(x => x.C_login == _login);
                    if (user != null)
                    {
                        if(user.C_login == _login)
                        {
                            ErrorMessage.Append("Пользователь стаким логином уже существует \n");
                        }
                        if(user.mail == email)
                        {
                            ErrorMessage.Append("Пользователь стаким емейлом уже существует \n");
                        }
                        if(user.phone == phone)
                        {
                            ErrorMessage.Append("Пользователь стаким номером телефона уже существует \n");
                        }
                        return ErrorMessage.ToString();
                    }
                    else
                    {
                        return "";
                    }
                    
                }
            }
            catch (Exception e)
            {
                nLog.WriteLog("DB_Entity_DAL -> DB_Operation -> DB_User -> searchUser :\r\n Message: " + e.Message + "\r\n " + e.StackTrace + "",  0);
                return "error";
            }
           
        }

        public string SignInUserCheckDataBase(string _login , string _password) // Sign In  
        {
            try
            {
                using (Sell_BuyEntities db = new Sell_BuyEntities())
                {
                    //StringBuilder ErrorMessage = new StringBuilder();
                    var user = db.Users.FirstOrDefault(u => u.C_login == _login && u.C_password == _password);
                    if (user == null)
                    {
                        return "Неверный логин или пароль";
                    }
                    else
                    {
                        return "id=" + user.id +"/success Добро пожаловать " + user.name_first + " " + user.name_middle;
                    }

                }
            }
            catch (Exception e)
            {
                nLog.WriteLog("DB_Entity_DAL -> DB_Operation -> DB_User -> SignInUserCheckDataBase :\r\n Message: " + e.Message + "\r\n " + e.StackTrace + "", 0);
                return e.Message;
            }
        }

        public bool InsertUser(User user)
        {
            try
            {
                Sell_BuyEntities db = new Sell_BuyEntities();
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                nLog.WriteLog("DB_Entity_DAL -> DB_Operation -> DB_User -> InsertUser :\r\n Message: " + e.Message + "\r\n " + e.StackTrace + "", 0);
                return false;
            }
        }


        public string UpdateUser(int id, User user)
        {

            try
            {

                Sell_BuyEntities db = new Sell_BuyEntities();
                User u = db.Users.Find(id);
                u.name_first = user.name_first;
                u.name_last = user.name_last;
                u.name_middle = user.name_middle;
                u.phone = user.phone;
                u.mail = user.mail;
                u.id_country = user.id_country;
                u.id_region = user.id_region;
                u.id_sity = user.id_sity;
                u.C_status = user.C_status;
                u.active = user.active;
                u.id_language = user.id_language;
                u.C_image = user.C_image;
                u.date_register = user.date_register;
                u.C_login = user.C_login;
                u.C_password = user.C_password;
                db.SaveChanges();
                return u.name_last + "was succefully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }

        }

        public string DeleteUser(int id)
        {
            try
            {
                Sell_BuyEntities db = new Sell_BuyEntities();
                User user = db.Users.Find(id);

                db.Users.Attach(user);
                db.Users.Remove(user);
                db.SaveChanges();

                return user.name_last + "was succefully delited";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        public User GetUser(int id)
        {
            try
            {
                using (Sell_BuyEntities db = new Sell_BuyEntities())
                {
                    User user = db.Users.Find(id);
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<User> GetallUsers()
        {
            try
            {
                using (Sell_BuyEntities db = new Sell_BuyEntities())
                {
                    List<User> user = (from x in db.Users
                                       select x).ToList();
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
