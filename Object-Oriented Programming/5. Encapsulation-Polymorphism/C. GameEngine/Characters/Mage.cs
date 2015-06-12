namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Mage : Character, IAttack
    {
        private const int MageHealthPoints = 150;
        private const int MageDefensePoints = 50;
        private const int MageAttackPoints = 300;
        private const int MageRange = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, MageHealthPoints, MageDefensePoints, team, MageRange)
        {
            this.AttackPoints = MageAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.LastOrDefault(trgt => (trgt.Team != this.Team && trgt.IsAlive));

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
            return string.Format("-- {0}, Attack: {1}", base.ToString(), this.AttackPoints);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }      
    }
}
