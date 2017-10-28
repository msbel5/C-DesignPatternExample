using GunExample.Bodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunExample.Services
{
    public class FireGun
    {  
        public void fireGun(Gun gun)
        {
            gun.Firing();
        }
        
    }
}
