using Backup.Backup_Exeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Backup to any device for save data";

            Flash_Device.FlashUSB flashUSB = new Flash_Device.FlashUSB("Adata", "UV360",35,32768);
            DVD_disc.DVD dvd_discRW = new DVD_disc.DVD("Verbatim", "AZO ", 177, 4812.8);
            DVD_disc.DVD bluerayBD_RE = new DVD_disc.DVD("Sony ", "Original Spindle ", 576, 25600);
            HDD_Device.HDD hdd = new HDD_Device.HDD("Toshiba ", "X300 ", 520, 614400);
            Storage[] storages = { flashUSB, dvd_discRW, bluerayBD_RE,hdd };

            foreach (var item in storages)
            {
                item.PrintDevice();
                item.Copy();
              
                item.FreeMemory();
           
                item.MediaSize();
                Console.WriteLine();

            }


            foreach (var item in storages)
            {
                try
                {
                    if (item is DVD_disc.DVD d)
                    {
                        item.PrintDevice();
                        item.Copy();

                        item.FreeMemory();

                        item.MediaSize();
                    }



                   else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        DateTime time = DateTime.Now;
                        throw new StorageExeption();
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }

                catch (StorageExeption ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.ReadKey();
        }
    }
}
