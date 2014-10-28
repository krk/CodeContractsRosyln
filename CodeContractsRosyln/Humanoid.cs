using System;

namespace CodeContractsRosyln
{
    public class Humanoid
    {
        /* This method has a dynamic local variable preventing it to be rewritten 
           by Code Contracts rewriter if the compiler is Roslyn. */
        public void Bark()
        {
            /* Method does not need to have a Contracts clause. */

            dynamic c = 1;

            Console.WriteLine(c.ToString());
        }
    }
}
