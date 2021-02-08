using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    namespace Flash_Device
    {
        class FlashUSB : Storage
        {
            public FlashUSB(string mediaName, string storageModel, double readwriteSpeed, double memory) : base(mediaName, storageModel)
            {
                ReadwriteSpeed = readwriteSpeed;
                Memory = memory;
            }

            public double ReadwriteSpeed { get; set; }
            public double Memory { get; set; }

            double mediaSize;
            double copySize;
            public override void Copy()
            {
                copySize = 587340 - (-Memory);

                Memory = -(587340 - (copySize));
            
                Console.WriteLine($" Copy file size in FlashUSB: {Memory/1024} GB");
            }

            public override void FreeMemory()
            {
                copySize = 587340 - (-Memory);

                Memory = -(587340 - (copySize));

                if(Memory> copySize)

                Console.WriteLine($" Free memory of FlashUSB: {Memory}");
                
                else
                {
                    Console.WriteLine($" Free memory of FlashUSB: {0}");
                }
               
            }

            public override void MediaSize()
            {
                mediaSize = 581623 -(- Memory);
                Memory = -(581623 - (mediaSize));
                Console.WriteLine($" Media count in FlashUSB: {Convert.ToInt32((Memory/780))}");
                Console.WriteLine(" =============================================================== \n");
            }

            public override void PrintDevice()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n ==== Flash USB ================================================ ");
                Console.WriteLine($" Storage media name: {MediaName}");
                Console.WriteLine($" Storage model: {StorageModel}");
                Console.WriteLine($" Storage Read \\  Write Speed: {ReadwriteSpeed*0.125} Megabyte");
                Console.WriteLine($" Data transver time: {Convert.ToInt32(Memory / 1024/ (ReadwriteSpeed * 0.125) *60)} minute \n");

               
            }
        }
    }
}
