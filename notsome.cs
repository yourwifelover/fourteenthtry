using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourteenthtry
{
    abstract class notsome
    {

        public void notsomeness()
        {
            Console.WriteLine("This is not some.");
        }

    }

    class notsomechild : notsome
    {
        public void notsomeness()
        {
            base.notsomeness();
        }
    }

}
