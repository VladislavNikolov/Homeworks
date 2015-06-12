namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Healer : Character, IHeal
    {
        private const int HealerHealthPoints = 75;
        private const int HealerDefensePoints = 50;
        private const int HealerHealingPoints = 60;
        private const int HealerRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealerHealthPoints, HealerDefensePoints, team, HealerRange)
        {
            this.HealingPoints = HealerHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList
                .OrderBy(trgt => trgt.HealthPoints)
                .FirstOrDefault(trgt => (trgt.Team == this.Team && trgt.IsAlive && trgt != this));

            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return string.Format("-- {0}, Healing: {1}", base.ToString(), this.HealingPoints);
        }
    }
}
