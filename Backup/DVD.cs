using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    namespace DVD_disc
    {
        class DVD : Storage
        {
            public DVD(string mediaName, string storageModel, int readwriteSpeed, double dvdType) : base(mediaName, storageModel)
            {
                ReadwriteSpeed = readwriteSpeed;
                DiscType = dvdType;
            }

            public int ReadwriteSpeed { get; set; }
            public double DiscType { get; set; }


            double mediaSize;
            double copySize;
            public override void Copy()
            {
                copySize = 587340 - (-DiscType);

                DiscType = -(587340 - (copySize));
                
                Console.WriteLine($" Copy file size in DVD disc: {DiscType / 1024} GB");
            }

            public override void FreeMemory()
            {
                copySize = 587340 - (-DiscType);

                DiscType = -(587340 - (copySize));

                if (DiscType > copySize)

                    Console.WriteLine($" Free memory of DVD disc: {DiscType}");

                else
                {
                    Console.WriteLine($" Free memory of DVD disc: {0}");
                }

            }

            public override void MediaSize()
            {
                mediaSize = 581623 - (-DiscType);
                DiscType = -(581623 - (mediaSize));
                Console.WriteLine($" Media count in DVD disc: {Convert.ToInt32((DiscType / 780))}");
                Console.WriteLine(" =============================================================== \n");
            }

            public override void PrintDevice()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n ==== DVD disc ================================================== ");
                Console.WriteLine($" Storage media name: {MediaName}");
                Console.WriteLine($" Storage model: {StorageModel}");
                Console.WriteLine($" Storage Read \\  Write Speed: {ReadwriteSpeed*0.125} Megabyte" );
                Console.WriteLine($" Data transver time: {Convert.ToInt32(DiscType / 1024/ (ReadwriteSpeed * 0.125) *60)} minute \n");

            }
        }
    }
}
