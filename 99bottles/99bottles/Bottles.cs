using System;
using System.Text;

namespace _99bottles
{
    public class Bottles
    {

        public string Verse(int i)
        {
            IBottleWallState bottleWallState;
            if (i > 1)
            {
                bottleWallState = new MultipleBottlesState(i);
            }
            else if (i == 1)
            {
                bottleWallState = new SingleBottleState();
            }
            else
            {
                bottleWallState = new NoBottlesState();
            }

            string currentText = bottleWallState.GetVerseCurrentText();
            string actionText = bottleWallState.GetVerseActionText();
            bottleWallState = bottleWallState.NextState();
            string nextText = bottleWallState.GetVerseCurrentText();

            return
                $"{currentText} of milk on the wall, " +
                $"{currentText.ToLower()} of milk.\n" +
                actionText +
                $"{nextText.ToLower()} of milk on the wall.\n";
        }

        public string Verses(int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int bottleCount = start; bottleCount > end; bottleCount--)
            {
                sb.Append(this.Verse(bottleCount));
                sb.Append('\n');
            }

            sb.Append(this.Verse(end));
            return sb.ToString();
        }

        public string Song()
        {
            return this.Verses(99, 0);
        }
    }
}
