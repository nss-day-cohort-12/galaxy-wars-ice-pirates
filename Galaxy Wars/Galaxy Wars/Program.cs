using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Species;
using Galaxy_Wars.Vehicles;

namespace Galaxy_Wars
{
    class Program
    {
        

    static void Fight(List<bool> rules, SpeciesClass first, SpeciesClass second)
        {
            var a = first.type;
            var b = second.type;
            Console.WriteLine(rules[0]);
            Console.WriteLine(rules[1]);
            Console.WriteLine(rules[2]);

            Console.WriteLine(first.population);
            Console.ReadKey();

            var combo = a + b;
            Console.WriteLine(combo);

            switch (combo)
            {
                case "ScienceReligion":
                    if (rules[0])
                    {
                        Console.WriteLine("Science beats religion");
                        second.population *= 0.98;
                    } else
                    {
                        Console.WriteLine("Religion beats science");
                        first.population *= 0.98;
                    }
                    break;
                case "ReligionWarMonger":
                    if (rules[1])
                    {
                        second.population *= 0.98;
                    } else
                    {
                        first.population *= 0.98;
                    }
                    //IWarrior species will kill an additional 10,000 of the opponent's population each year, but also lose an additional 2,500 population each year.
                    first.population -= 10000;
                    second.population -= 2500;
                    break;
                case "WarMongerScience":
                    if (rules[2])
                    {
                        second.population *= 0.98;
                    }
                    else
                    {
                        first.population *= 0.98;
                    }
                    //IWarrior species will kill an additional 10,000 of the opponent's population each year, but also lose an additional 2,500 population each year.
                    second.population -= 10000;
                    first.population -= 2500;
                    break;
            }

        }




        static void Main(string[] args)
        {


            // [science beats religion, religion beats warfare, warefare beats science]
            List<bool> rules = new List<bool> { true, true, true };

            Hydrologists hy = new Hydrologists();
            Santa Santa = new Santa();
            hy.vehicleType = Santa;
            Console.WriteLine("Hydrologist type " + hy.type);
            Console.ReadKey();

            IcePirates IcePirates = new IcePirates();
            Nina Nina = new Nina();
            IcePirates.vehicleType = Nina;

            Parched Parched = new Parched();
            Pinta Pinta = new Pinta();
            Parched.vehicleType = Pinta;

           

            int year = 1;
            bool allAlive = true;


            while (allAlive)
            {
                hy.population -= 20000;
                IcePirates.population -= 20000;
                Parched.population -= 20000;

                if (year % 25 == 0)
                {
                    var random = new Random();
                    var idx = random.Next(0, 2);
                    Console.WriteLine("idx" + idx);
                    rules[idx] = !rules[idx];
                }

                Console.WriteLine(Parched.population + "before fight");
                Fight(rules, hy, Parched);
                Console.WriteLine(Parched.population + "after fight");

                if ( hy.population <= 0)
                {
                    Console.Write("hydrologists have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }
                if (Parched.population <= 0)
                {
                    Console.Write("Parched have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }

                Fight(rules, Parched, IcePirates);
                if (Parched.population <= 0)
                {
                    Console.Write("Parched have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }
                if (IcePirates.population <= 0)
                {
                    Console.Write("Ice Pirates have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }

                Fight(rules, IcePirates, hy);
                if (IcePirates.population <= 0)
                {
                    Console.Write("Ice Pirates have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }
                if (hy.population <= 0)
                {
                    Console.Write("Hydrologists have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }


                //ISpaceFaring species will recover a bonus of 5,000 population after each year.
                hy.Clone();

                //IReligious species convert 1% of the opponent's current population to their side each year.
                Parched.population += 0.01 * (hy.population + IcePirates.population);
                hy.population *= 0.99;
                IcePirates.population *= 0.99;

                Console.WriteLine("The Year is {0}", year);
                Console.WriteLine("Hydrologists: {0}", hy.population);
                Console.WriteLine("Parched: {0}", Parched.population);
                Console.WriteLine("IcePirates: {0}", IcePirates.population);

                year++;
            }

        }
    }
}
