using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_LINQ_com_notação_SLQ.Entites
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Tier { get; set; }

        public Category(int id, string name, int tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }
    }
}
