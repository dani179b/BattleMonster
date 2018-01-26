using System.Data.Common;

namespace BattleMonster
{
    public class Monster
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public MonsterType Type { get; set; }

        public Monster(string name, double damage, double health, MonsterType type)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Type = type;
        }

        public Monster(MonsterType type)
        {
            this.Type = type;
        }
    }
}