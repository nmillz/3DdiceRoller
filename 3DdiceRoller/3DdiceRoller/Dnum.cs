using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3DdiceRoller
{
    class Dnum
    {
        int Velocity = -1, sides;
        int[] VectorCoords = new int[3];
        //bitmap texture;
        
       //this is commented out so that the program can run

       //bool setVelocity()
       // {
       //     Velocity = Dnum.Rand(1, 3);
       //     if (Velocity >= 0)
       //         return true;
       //     else
       //         return false;
       // }

        bool simulateNextIteration()
        {
            return true;
        }

        int getVelocity()
        {
            return Velocity;
        }

        int getValue()
        {
            return 0;
        }

        int getSides()
        {
            return sides;
        }

        /*Dnum Dnum(int sides, bitmap texture)
        {

        }*/

        /*int Rand(int max, int min)
        {
            return randNum;
        }*/
       
    }

}
