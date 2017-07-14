using DB_Entity_DAL.DB_Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationTools.common
{
    public class UserInfo
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
    }

    public class UpdateInfoUserProfileTools
    {
        DB_User dbuser = new DB_User();
        public UserInfo GetAllInfoUser(int id)
        {
            UserInfo user = null;
            var usInfo = dbuser.GetUser(id);

            if(usInfo != null)
            {
                user = new UserInfo
                {
                    Surname = usInfo.name_first,
                    Name = usInfo.name_middle,
                    LastName = usInfo.name_last,
                    Phone = usInfo.phone,
                    Mail = usInfo.mail,
                    Login = usInfo.C_login,
                    Password = usInfo.C_password,
                    Country = Convert.ToString(usInfo.id_country),
                    Region  = Convert.ToString(usInfo.id_region),
                    City = Convert.ToString(usInfo.id_sity),
                    Image = usInfo.C_image

                };
            }

            return user;
        }

    }
}
