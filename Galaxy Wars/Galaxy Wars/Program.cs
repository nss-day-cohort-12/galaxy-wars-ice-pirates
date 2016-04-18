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
        


        public void Fight(Dictionary<string, string> rules, SpeciesClass first, SpeciesClass second)
        {
            if (rules[first.type] == second.type)
            {
                second.population = second.population * 0.98;
            } else if (rules[second.type] == first.type)
            {
                first.population = first.population * 0.98;
            }
        }


        static void Main(string[] args)
        {
            Dictionary<string, string> rules = new Dictionary<string, string>();
            rules.Add("Science", "Religion");
            rules.Add("Religion", "WarMonger");
            rules.Add("WarMonger", "Science");

            Hydrologists Hydrologists = new Hydrologists();
            Santa Santa = new Santa();
            Hydrologists.vehicleType = Santa;

            IcePirates IcePirates = new IcePirates();
            Nina Nina = new Nina();
            IcePirates.vehicleType = Nina;

            Parched Parched = new Parched();
            Pinta Pinta = new Pinta();
            Parched.vehicleType = Pinta;

           

            int year = 0;
            bool allAlive = true;


            while (allAlive)
            {
                Hydrologists.population -= 20000;
                IcePirates.population -= 20000;
                Parched.population -= 20000;

                if (year % 25 == 0)
                {

                }



                year++;
            }

        }
    }
}
