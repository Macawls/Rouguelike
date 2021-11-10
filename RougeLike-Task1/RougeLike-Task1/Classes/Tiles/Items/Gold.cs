using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Classes.Tiles.Items
{
    class Gold : Item
    {
        private int goldAmount;


        private Random random = new Random();
           
        public int GoldAmount
        {
            get { return goldAmount; }
            set { goldAmount = value; }
        }



        public Gold(int x, int y) : base(x, y, 'O')
        {
            goldAmount = random.Next(1, 6); //between 1 and 5
        }

        public override string ToString()
        {
            return $"Gold at [{this.x}, {this.y}]";
        }
    }
}
