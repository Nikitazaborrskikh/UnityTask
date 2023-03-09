namespace UnityTask.Abstract
{
    public interface IHero
    {
        string Name { get; set; }
        string[] Abilities { get; set; }

        public abstract void Attack(IHero enemy);

        public abstract void TakeDamage(int damage, IHero attacker);


    }
}

