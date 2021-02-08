using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    abstract class Storage
    {
        public Storage(string mediaName, string storageModel)
        {
            MediaName = mediaName;
            StorageModel = storageModel;
        }

        public string MediaName { get; set; }
        public string StorageModel { get; set; }

        public abstract void MediaSize();
        public abstract void Copy();

        public abstract void FreeMemory();

        public abstract void PrintDevice();
    }
}
