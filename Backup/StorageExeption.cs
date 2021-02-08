using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    namespace Backup_Exeption
    {
        class StorageExeption : ApplicationException
        {
            private string _message;
            public DateTime TimeExeption { get; set; }

            public StorageExeption()
            {
                _message = " Your can not access in this Data";
                TimeExeption = DateTime.Now;

                Console.WriteLine($" {TimeExeption} ");

            }
            public StorageExeption(string message)
            {
                _message = message;
            

            }

            public string Message
            {

                get { return _message; }


            }


        }
    }
}
