using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleMonster
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monsterBob = new Monster("Bob", 20.0, 100.0, MonsterType.Fire);
            Monster monsterLeo = new Monster(MonsterType.Water);

        }
    }
}
