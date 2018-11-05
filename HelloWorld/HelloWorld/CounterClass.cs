using System;
using System.Collections.Generic;
using System.Text;

namespace OtherPersonsCode
{
    class CounterClass
    {
        private int workUntilYouGet = 10; //just using attributes 10 bags of peanuts
        private float youGetPerCycle = 0.1f; //get 10% of the bag per cycle.
        private float earnPerDay = 1.0f; //get one bag of peanuts
        private bool arePeanutsCollected = false; //peanut flag

        public bool work()
        {
            for (int i = 0; i < this.workUntilYouGet; i++) //work for 10 days
            {
                for (float j = 0; j <= this.earnPerDay; j += this.youGetPerCycle) //work until you get DayPay at certain tarif 
                {
                    this.peanutCheck(i, j);
                }
            }

            return arePeanutsCollected; //work pays off here

        }

        private void peanutCheck(int i, float j) //checks if we got 10 bags of peanuts.
        {
            if (i + j + 0.1f == 10)
            {
                this.arePeanutsCollected = true;
            }
            else
            {
                this.arePeanutsCollected = false;
            }
        }
    }
}
