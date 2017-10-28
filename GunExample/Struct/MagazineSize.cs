using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Struct
{
    public struct MagazineSize
    {
        private int _magSize;
        public int magSize
        {
            get { return _magSize; }
            set
            {
                if (_magSize > 0)
                {
                    _magSize = value;
                }
            }
        }

        public MagazineSize getMagSize()
        {
            return this;
        }
    }
}
