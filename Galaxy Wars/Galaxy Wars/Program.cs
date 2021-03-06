﻿using System;
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
        
        static void Main(string[] args)
        {


            // [science beats religion, religion beats warfare, warefare beats science]
            List<bool> rules = new List<bool> { true, true, true };

            Hydrologists Hydrologists = new Hydrologists();
            Santa Santa = new Santa();
            Hydrologists.vehicleType = Santa;

            IcePirates IcePirates = new IcePirates();
            Nina Nina = new Nina();
            IcePirates.vehicleType = Nina;

            Parched Parched = new Parched();
            Pinta Pinta = new Pinta();
            Parched.vehicleType = Pinta;

           

            int year = 1;
            bool allAlive = true;
            var random = new Random();


            while (allAlive)
            {

                Hydrologists.population -= random.Next(13000, 17000);
                IcePirates.population -= random.Next(13000, 17000);
                Parched.population -=  random.Next(13000, 17000);
                

                if (year % 10 == 0)
                {
                    var idx = random.Next(0, 2);
                    rules[idx] = !rules[idx];
                }
                Console.WriteLine(rules[0]);
                Console.WriteLine(rules[1]);
                Console.WriteLine(rules[2]);
                //Battles
                //Science fights Religion 
                if (rules[0])
                {
                    Parched.population *= 0.98;
                }
                else
                {
                    Hydrologists.population *= 0.98;
                }
                //Death Checks
                if (Hydrologists.population <= 0)
                {
                    Console.Write("Hydrologists have died.");
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

                //Religion fights WarMongers
                if (rules[1])
                {
                    IcePirates.population *= 0.98;
                }
                else
                {
                    Parched.population *= 0.98;
                }
                //IWarrior species will kill an additional 10,000 of the opponent's population each year, but also lose an additional 2,500 population each year.
                Parched.population -= 10000;
                IcePirates.population -= 2500;
                //Death Checks
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


                //WarMongers fight Science
                if (rules[2])
                {
                    Hydrologists.population *= 0.98;
                }
                else
                {
                    IcePirates.population *= 0.98;
                }
                //IWarrior species will kill an additional 10,000 of the opponent's population each year, but also lose an additional 2,500 population each year.
                Hydrologists.population -= 10000;
                IcePirates.population -= 2500;
                //Death Checks
                if (IcePirates.population <= 0)
                {
                    Console.Write("Ice Pirates have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }
                if (Hydrologists.population <= 0)
                {
                    Console.Write("Hydrologists have died.");
                    Console.ReadKey();
                    allAlive = false;
                    continue;
                }


                //ISpaceFaring species will recover a bonus of 5,000 population after each year.
                var growth = random.Next(3000, 7000);
                Hydrologists.Clone(growth);

                //IReligious species convert 1% of the opponent's current population to their side each year.
                Parched.population += 0.005 * (Hydrologists.population + IcePirates.population);
                Hydrologists.population *= 0.995;
                IcePirates.population *= 0.995;

                Console.WriteLine("The Year is {0}", year);
                Console.WriteLine("Hydrologists: {0}", Hydrologists.population);
                Console.WriteLine("Parched: {0}", Parched.population);
                Console.WriteLine("IcePirates: {0}", IcePirates.population);

                year++;
                Console.ReadKey();
            }

        }
    }
}
