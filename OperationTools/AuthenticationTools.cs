using DB_Entity_DAL.DB_Operations;
using DB_Entity_DAL.MedelsDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationTools
{
    public class AuthenticationTools
    {
        // Add new uesr for database 
        //      return res =  
        //  
        //
        private DB_User dbUser = new DB_User();
        private User user = null;
        public int RegisterUser(string _surname , string _name , string _lastname 
            , string _phone , string _email , string _login
            , string _password , int _idcountry , int _idRegion
            , int _idSity , string _photo
            )
        {

            bool checkUser = dbUser.searchUser(_login);

            if (checkUser)
            {
                user = new User
                {
                    name_first = _surname,
                    name_last = _lastname,
                    name_middle = _name,
                    phone = _phone,
                    mail = _email,
                    id_country = _idcountry,
                    id_region = _idRegion,
                    id_sity = _idSity,
                    C_status = 1,
                    active = 1,
                    id_language = 1,
                    C_image = _photo.ToString(),

                    C_login = _login.ToString(),
                    C_password = _password.ToString()
                };

                dbUser.InsertUser(user);
                return 1;
            }
            else
            {
                return 0;
            }

            
           
        }

    }
}
