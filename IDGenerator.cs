using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryzhevska_lab
{
    class IDGenerator
    {
        private long _id;
        public long Id
        {
            get { return _id == long.MaxValue ? 0 : ++_id; }
        }

        public IDGenerator Clear()
        {
            if (this != null)
                _id = 0;

            return this;
        }
    }
}
