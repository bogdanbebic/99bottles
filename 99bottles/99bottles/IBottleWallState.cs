using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    public interface IBottleWallState
    {
        IBottleWallState NextState();

        string GetVerseCurrentText();

        string GetVerseActionText();
    }
}
