﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Gold : Item
    {

        private Random rnd = new Random();
        private int num_gold;

        public Gold(int x,int y) : base(x, y)
        {
            num_gold = rnd.Next(1, 6);
        }

        public override string ToString()
        {
            return "Gold";
        }

        public int getGold()
        {
            return num_gold;
        }

    }
}