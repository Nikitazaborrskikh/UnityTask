using UnityTask.Abstract;

namespace UnityTask
{
    public class HeroFactory
    {
        private ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }

        public IHero CreateWarrior()
        {
            var logger = CreateLogger();
            int damage = 10;
            int damageMultiplyer = 2;
            var abilities = new[]
            {
                new SwordAttack().Name,
            };

            return new Warrior
            {
                Name = "Warrior",
                Abilities = abilities,
                Logger = logger,
                Damage = damage,
                DamageMultiplyer = damageMultiplyer
            };
        }

        public IHero CreateFireWarrior()
        {
            var logger = CreateLogger();
            int damage = 15;
            int damageMultiplyer = 2;
            int firedamage = 10;
            var abilities = new[]
            {
                new SwordAttack().Name,
                new FireAttack().Name
            };

            return new FireWarrior
            {
                Name = "Fire Warrior",
                Abilities = abilities,
                Logger = logger,
                Damage = damage
            };
        }

        public IHero CreateFrostWarrior()
        {
            var logger = CreateLogger();
            int damage = 15;
            var abilities = new[]
            {
                new SwordAttack().Name,
                new FrostAttack().Name
            };

            return new FrostWarrior
            {
                Name = "Frost Warrior",
                Abilities = abilities,
                Logger = logger,
                Damage = damage
            };
        }
        public class Warrior : IHero
        {
            public string Name { get; set; }
            public string[] Abilities { get; set; }
            public ILogger Logger { get; set; }
            public int Damage;
            public int DamageMultiplyer;
            void IHero.Attack(IHero enemy)
            {
                this.Logger.Log($"{this.Name} attacks {enemy.Name}");
                enemy.TakeDamage(this.Damage, this);
            }
            void IHero.TakeDamage(int damage, IHero attacker)
            {
                this.Logger.Log($"{this.Name} got hit by {attacker.Name} and received {damage * DamageMultiplyer} damage");
            }

        }

        public class FireWarrior : IHero
        {
            public int Damage;

            public string Name { get; set; }
            public string[] Abilities { get; set; }
            public ILogger Logger { get; set; }
            public int damageMultiplyer;
            public int FireDamage;

            void IHero.Attack(IHero enemy)
            {
                this.Logger.Log($"{this.Name} attacks {enemy.Name}");
                enemy.TakeDamage(this.Damage, this);
            }
            void IHero.TakeDamage(int damage, IHero attacker)
            {
                this.Logger.Log($"{this.Name} got hit by {attacker.Name} and received {damage} damage");
            }

        }

        public class FrostWarrior : IHero
        {
            public int Damage;
            public string Name { get; set; }
            public string[] Abilities { get; set; }
            public ILogger Logger { get; set; }

            void IHero.Attack(IHero enemy)
            {
                this.Logger.Log($"{this.Name} attacks {enemy.Name}");
                enemy.TakeDamage(this.Damage, this);
            }
            void IHero.TakeDamage(int damage, IHero attacker)
            {
                this.Logger.Log($"{this.Name} got hit by {attacker.Name} and received {damage} damage");
            }
        }
    }
}
