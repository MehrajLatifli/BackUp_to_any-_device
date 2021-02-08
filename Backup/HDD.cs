using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    namespace HDD_Device
    {
        class HDD : Storage
        {
            public HDD(string mediaName, string storageModel, int readwriteSpeed, double memory) : base(mediaName, storageModel)
            {
                ReadwriteSpeed = readwriteSpeed;
                Memory = memory;
            }

            public int ReadwriteSpeed { get; set; }
            public double Memory { get; set; }

            double mediaSize;
            double copySize;
            public override void Copy()
            {
                copySize = 587340 - (-Memory);

                Memory = -(587340 - (copySize));

                Console.WriteLine($" Copy file size in HDD: {Memory/1024 } GB");
            }

            public override void FreeMemory()
            {
                copySize = 587340 - (-Memory);

                Memory = -(587340 - (copySize));

            

                    Console.WriteLine($" Free memory of HDD: {Memory-(-(Memory - copySize))}");

                

            }

            public override void MediaSize()
            {
                mediaSize = 581623 - (-Memory);
                Memory = -(581623 - (mediaSize));
                if(Memory / 780 >753){
                    Console.WriteLine($" Media count is Full and you have free space for {Convert.ToInt32(((Memory / 780) - 753))} media");
                    Console.WriteLine(" ================================================================ \n");
                }
                else
                {
                    Console.WriteLine($" Media count in HDD: {Convert.ToInt32((Memory / 780))}");
                }
            }

            public override void PrintDevice()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n ==== HDD ====================================================== ");
                Console.WriteLine($" Storage media name: {MediaName}");
                Console.WriteLine($" Storage model: {StorageModel}");
                Console.WriteLine($" Storage Read \\  Write Speed: {ReadwriteSpeed} Megabyte");
                Console.WriteLine($" Data transver time: {Convert.ToInt32(Memory / 1024 / ReadwriteSpeed * 60)} minute \n");

            }
        }
    }
    
}
