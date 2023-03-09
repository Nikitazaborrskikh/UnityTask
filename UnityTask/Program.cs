using UnityTask.Abstract;
namespace UnityTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroFactory = new HeroFactory();
            var logger = new ConsoleLogger();
            var warrior = heroFactory.CreateWarrior();
            var fireWarrior = heroFactory.CreateFireWarrior();
            var frostWarrior = heroFactory.CreateFrostWarrior();


            warrior.Attack(fireWarrior);



            fireWarrior.Attack(frostWarrior);





            frostWarrior.Attack(warrior);


            Console.ReadLine();
        }
    }


    public class SwordAttack
    {
        public string Name => "Sword Attack";
    }

    public class FireAttack
    {
        public string Name => "Fire Attack";
    }

    public class FrostAttack
    {
        public string Name => "Frost Attack";
    }





    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}