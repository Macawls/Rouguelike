using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Classes
{
    class GameEngine
    {
        private static Map map;

        // get accessor
        public Map GetMap { get; }

        // Ctor
        public GameEngine()
        {
            map = new Map(7, 7, 7, 7, 2);
        }

        // Please see the code under GameForm.cs, thats as far as I've gotten with developing a prototype for the movement logic. 


    }
}
