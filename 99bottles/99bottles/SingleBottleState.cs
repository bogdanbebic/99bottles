using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    public class SingleBottleState : IBottleWallState
    {
        public string GetVerseActionText()
        {
            return "Take it down and pass it around, ";
        }

        public string GetVerseCurrentText()
        {
            return "1 bottle";
        }

        public IBottleWallState NextState()
        {
            return new NoBottlesState();
        }
    }
}
