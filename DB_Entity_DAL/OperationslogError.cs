using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Entity_DAL
{
    public class OperationslogError
    {
        public void WriteLogError(string storename, string place, string sText, int showDate)
        {
            try
            {
                //using (StreamWriter chukcha = new StreamWriter(ConfigurationManager.AppSettings["FilesLog"] + "Error.log", true))
                using (StreamWriter chukcha = new StreamWriter("Error.log", true))
                {
                    if (showDate == 0)
                    {
                        chukcha.WriteLine(String.Format("{0:MM/dd/yyyy HH:mm:ss}", DateTime.Now) + "  " + storename + "  " + place + "\r\n" + sText);
                    }
                    else
                    {
                        chukcha.WriteLine(sText);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
