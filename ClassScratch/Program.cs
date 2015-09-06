using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandList = new List<RockBand>();

            var ledzep = new ClassicRock();
            ledzep.BandName = "Led Zeppelin";
            ledzep.Singer = new BandMember
            {
                Name = "Robert Plant",
                Crazy = false,
                DrugAddict=false,
                IsDead=false
            };
            bandList.Add(ledzep);

            var dbt = new AltCountry
            {
                BandName = "Drive-By Truckers",
                Singer = new BandMember {
                    Name = "Patterson Hood",
                    Crazy = false,
                    DrugAddict = false,
                    IsDead = false
                },
            };

            bandList.Add(dbt);

            foreach (var item in bandList)
            {
                if(item.GetType() == typeof(AltCountry))
                {
                    Console.WriteLine("There is an alt country singer named {0} here.", item.Singer.Name);
                }
                if(typeof(RockBand).IsAssignableFrom(item.GetType()))
                {
                    Console.WriteLine("There is a singer for a band that descends from type 'RockBand' named {0} here.", item.Singer.Name);
                }
            }
            Console.ReadLine();
            
        }

        public abstract class Person
        {
            public string Name { get; set; }
            public bool IsDead { get; set; }
        }

        public class BandMember : Person
        {
            public bool Crazy { get; set; }
            public bool DrugAddict { get; set; }

        }

        public abstract class RockBand
        {
            public string BandName { get; set; }
            public BandMember Drummer { get; set; }
            public BandMember Singer { get; set; }
            public BandMember LeadGuitarist { get; set; }
            public BandMember Bassist { get; set; }
            public BandMember RhythmGuitarist { get; set; }
            public BandMember Keyboardist { get; set; }
        }

        public class ClassicRock : RockBand
        {
            public bool IsHeavy { get; set; }
            public bool IsLight { get; set; }

        }

        public class AltCountry: RockBand
        {
            public bool IsDepressed { get; set; }

        }



    }
}
