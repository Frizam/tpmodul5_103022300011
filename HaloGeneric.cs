using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300011
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)//method untuk menyapa user dengan generic parameter
        {
            Console.WriteLine($"Halo user {user}");
        }
    }
}
