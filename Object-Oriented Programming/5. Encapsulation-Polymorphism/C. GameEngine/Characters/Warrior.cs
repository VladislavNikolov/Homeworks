namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Warrior : Character, IAttack
    {
        private const int WarriorHealthPoints = 200;
        private const int WarriorDefensePoints = 100;
        private const int WarrorAttackPoints = 150;
        private const int WarriorRange = 2;

        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, WarriorHealthPoints, WarriorDefensePoints, team, WarriorRange)
        {
            this.AttackPoints = WarrorAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.FirstOrDefault(trgt => (trgt.Team != this.Team && trgt.IsAlive));

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
