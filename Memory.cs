using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryzhevska_lab
{
    class Memory
    {
        public long Size { get; private set; }
        public long OccupiedSize { get; set; }
        public long FreeSize { get; private set; }


        public void Save(long size)
        {
            FreeSize = Size = size;
            OccupiedSize = 0;
        }
        public void Clear()
        {
            OccupiedSize = 0;
        }
    }
}
