using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    public class NoBottlesState : IBottleWallState
    {
        public string GetVerseActionText()
        {
            return "Go to the store and buy some more, ";
        }

        public string GetVerseCurrentText()
        {
            return "No more bottles";
        }

        public IBottleWallState NextState()
        {
            return new MultipleBottlesState(99);
        }
    }
}
