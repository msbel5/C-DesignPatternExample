using GunExample.Generic;
using GunExample.Interfaces;
using GunExample.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Bodies
{
    public class Gun : AttachMagazine, DetachMagazine
    {
        private EventArgs _args = new EventArgs();
        private bool _MaginPlace = false;
        private bool _IsAbletoFire = false;

        public Cartridges GunCartridges { get; set; }
        public MagazineSize GunMagSize { get; set; }
        public Magazine<Cartridges> GunMagazine { get; set; }

        public event EventHandler GunFiring;
        public event EventHandler GunReloading; 

        public void Firing()
        {
            GunFiring.Invoke(this, _args);
        }
        public void Reloading()
        {
            GunReloading.Invoke(this, _args);
        }

        public bool IsFired()
        {
            return GunMagazine.MagFiring();
        }

        public bool IsReloaded()
        {
            return GunMagazine.MagReloading(GunMagSize);
        }

        public bool Attaching()
        {
            if (_MaginPlace == false && GunMagazine.Contents.Length > 0)
            {
                _MaginPlace = true;
                _IsAbletoFire = true;
                return true;
            }
            return false;
        }

        public bool Detaching()
        {
            if (_MaginPlace == true && _IsAbletoFire == false)
            {
                _MaginPlace = false;
                return true;
            }
            return false;
        }
    }
}
