using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsAND2forms
{
    [Serializable]
    public class userScore
    {
        public string name;
        public int spend;
        public int win;

        public userScore()
        { }
        public userScore(string s, int a, int b)
        {
            name = s;
            spend = a;
            win = b;
        }

        public override string ToString()
        {
            return name + "-" + spend + ":" + win;
        }

    }
}
