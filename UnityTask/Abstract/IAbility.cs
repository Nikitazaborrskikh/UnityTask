namespace UnityTask.Abstract
{
    public interface IAbility
    {
        string Name { get; }
        int Damage { get; }
        float AreaOfEffect { get; }

        public void Use()
        {

        }
    }
}
