using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Tiles.Items
{
    class Gold : Item
    {
        private int goldAmount;


        private Random random = new Random();
           
        public int MaxGoldAmount
        {
            get { return goldAmount; }
            set { goldAmount = value; }
        }

        public Gold(int x, int y) : base(x, y, 'G') //added max value for goldAmount
        {
            goldAmount = 5; //max value for gold
        }

        public override string ToString()
        {
            return $"Gold at [{this.x}, {this.y}]";
        }
    }
}
