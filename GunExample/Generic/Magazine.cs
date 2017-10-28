using GunExample.Interfaces;
using GunExample.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Generic
{
    public class Magazine<T>: ReloadMagazine
    {
        private T _t;
        private T[] _contents;
        public T[] Contents
        {
            get
            {
                return _contents;
            }
        }
        public Magazine(int capacity)
        {
            _contents = new T[0];
        }

        public bool MagFiring()
        {
            if (_contents.Length > 0)
            {
                _contents[_contents.Length - 1] = default(T);
                Array.Resize(ref _contents, _contents.Length - 1);
                return true;
            }
            else
            {
                return false; 
            }
        }
        public bool MagReloading(MagazineSize magSize)
        {
            if (_contents.Length == 0)
            {
                for (int i = 0; i < magSize.magSize; i++)
                {
                    Array.Resize(ref _contents, _contents.Length + 1);
                    _contents[i] = _t;
                }
                return true;
            }
            else
                return false;
        }

    }
}
