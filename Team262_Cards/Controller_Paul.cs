using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team262_Cards
{
    class Controller_Paul
    {
        Calc_Grant calc1;
        Output_RJ out1;

        public Controller_Paul()
        {
            calc1 = new Calc_Grant();//instance
            out1 = new Output_RJ(ref calc1);//pass calc1 by ref


            beginShuffle();
        }//end constructor

        private void beginShuffle()
        {

        }//end beginShuffle

    }//end class
        
}//end namespace
