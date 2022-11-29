using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Druid druid = new Druid("druid", 1, 500);
            Hunter hunter = new Hunter("hunter", 1, 400);
            Warrior warrior = new Warrior("warrior", 1, 450);

            Console.WriteLine(hunter.HeroInformation());
            Console.WriteLine(warrior.HeroInformation());
            Console.WriteLine(druid.HeroInformation());

            List<IRampage> rampages = new List<IRampage>()
            {
                new Hunter(),
            };

            foreach (var e in rampages)
            {
                e.UltraAttack(druid);

                //Console.WriteLine(druid.HeroInformation());
            }

            Console.WriteLine(druid.HeroInformation());

            foreach (var e in rampages)
            {
                e.Recharge();

                //Console.WriteLine(druid.HeroInformation());
            }

            foreach (var e in rampages)
            {
                e.UltraAttack(druid);

                //Console.WriteLine(druid.HeroInformation());
            }
            Console.WriteLine(druid.HeroInformation());

            foreach (var e in rampages)
            {
                e.UltraAttack(druid);

                //Console.WriteLine(druid.HeroInformation());
            }
            Console.WriteLine(druid.HeroInformation());
        }
    }
}
