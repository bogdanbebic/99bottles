using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    public class MultipleBottlesState : IBottleWallState
    {
        private int BottleCount { get; }

        public MultipleBottlesState(int bottleCount)
        {
            this.BottleCount = bottleCount;
        }

        public string GetVerseActionText()
        {
            return "Take one down and pass it around, ";
        }

        public string GetVerseCurrentText()
        {
            return $"{this.BottleCount} bottles";
        }

        public IBottleWallState NextState()
        {
            return this.BottleCount == 2
                ? new SingleBottleState()
                : new MultipleBottlesState(this.BottleCount - 1);
        }
     }
}
