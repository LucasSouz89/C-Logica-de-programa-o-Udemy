using ExComposicao.Ex1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex1.Class
{
    internal class Player
    {
        public string Name { get;  set; }
        public Rank Rank { get; private set; }

        public Guild Guild { get; set; }

        public List<Quest> Quests { get; private set; } = new List<Quest>();

        public Player() { }

        public Player(string name, Rank rank, Guild guild)
        {
            Name = name;
            Rank = rank;
            Guild = guild;
            
        }

        public int TotalXpGained(int year, int mouth)
        {
           
            int sum = 0;
            foreach (var q in Quests) {
                if (q.Date.Year == year && q.Date.Month == mouth)
                {
                    sum += q.XpReward;
                }
                
            }
            return sum;
            
        }
        public void AddQuest(Quest quest) {
            Quests.Add(quest);
        }
        public override string ToString()
        {
            return $"Nome: {Name} | Guilda: {Guild.Name} | Rank {Rank.ToString()} | Total de quest {Quests.Count}";
        }
    }
}
