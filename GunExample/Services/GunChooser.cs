using GunExample.Bodies;
using GunExample.Generic;
using GunExample.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Services
{
    public class GunChooser
    {
        public Gun spawnGun(Cartridges cart, int magSize)
        {
            Gun gun = new Gun();
            MagazineSize _magSize = new MagazineSize();
            var type = Type.GetType(cart as Cartridges);
            Magazine<typeof(cart)> gunMag = new Magazine<cart>.Magazine(magSize);
            _magSize.magSize = magSize;
            gun.GunCartridges = cart;
            gun.GunMagSize = _magSize;
            return new Gun();
        }
    }
}
