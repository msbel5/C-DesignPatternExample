using GunExample.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Interfaces
{
    public interface ReloadMagazine
    {
        bool MagReloading(MagazineSize magSize);
    }
}
