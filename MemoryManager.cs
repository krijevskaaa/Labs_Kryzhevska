using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryzhevska_lab
{
    class MemoryManager
    {
        private Memory _memory;

        public void Save(Memory memory)
        {
            _memory = memory;
        }
        public Memory Allocate(Process process)
        {
            if (_memory.FreeSize >= process.AddrSpace)
            {
                _memory.OccupiedSize += process.AddrSpace;
                return _memory;
            }
            return null;
        }
        public Memory Free(Process process)
        {
            _memory.OccupiedSize -= process.AddrSpace;
            return _memory;
        }
    }
}
