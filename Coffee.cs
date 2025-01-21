using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_practice
{
    public interface ICoffee
    {
        string Make();
    }

    class EmptyCoffee : ICoffee
    {
        public string Make()
        {
            return "Made a empty coffee";
        }
    }

}
