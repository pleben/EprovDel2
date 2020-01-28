using System;
using System.Collections.Generic;
using System.Text;

namespace E_Prov_Del2
{
    class Car
    {

        public int passangers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();


        public static Random carGenerator = new Random(7);

        public Car()
        {

        }


        public void Examine(bool examine) 
        {

        }

    }
}
