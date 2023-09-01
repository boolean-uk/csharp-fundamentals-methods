using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_methods.Main
{
    internal class Baking
    {
        public int _isBaking;
     public int isBaking { get => _isBaking; set => _isBaking = value; }

        public void bakingStatus()
        {
            if (_isBaking == 0)
            {
                Console.WriteLine("The cake is ready!");
            }
            if  (_isBaking < 0) 
            {
                Console.WriteLine("The timer finished ages ago!");
            }
            if (_isBaking > 0) 
            {
                Console.WriteLine("The cake is still baking!");
            }
        }
    }
}
