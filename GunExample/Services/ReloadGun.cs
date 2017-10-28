using GunExample.Bodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Services
{
    public class ReloadGun
    {
        public void reloadGun(Gun gun)
        {
            gun.Reloading();            
        }
    }
}
