using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex1.Class
{
    internal class Quest
    {
        public string Title { get; private set; }
        public DateTime Date { get; private set; }

        public int XpReward { get; private set; }


        public Quest() { }
        public Quest(string title, DateTime date, int xpReward)
        {
            Title = title;
            Date = date;
            XpReward = xpReward;
        }
    }
}
