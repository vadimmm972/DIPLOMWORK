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
        private AllUrlPuth url = new AllUrlPuth();
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
                    Image = url.photoProfileUserPuth+ usInfo.C_image

                };
            }

            return user;
        }


        //public string UpdateInfoUser(int _param , int _idUser , string _newSurname)
        //{
        //    switch (_param)
        //    {
        //        case 1: // update info surnaem
        //            break;
        //        case 2: // update info name
        //            break;
        //        case 3: // update info lastname
        //            break;
        //        case 4: // update info phone
        //            break;
        //        case 5: // update info 
        //            break;
        //        case 6:
        //            break;
        //        default:
        //            return "Error exception !";
        //    }
        //    return "";
        //}


        public string UpdateInfoProfileByParamsTools(int _param, int _id, string _newSurname)
        {
               string strResult = "";
            switch(_param)
            {
                case 1:
                    strResult = dbuser.UpdateInfoSurnameProfile(_id, _newSurname);
                    break;
                case 2:
                    strResult = dbuser.UpdateInfoNameProfile(_id, _newSurname);
                    break;
            }

       
            return strResult;
        }

       

        

    }
}
