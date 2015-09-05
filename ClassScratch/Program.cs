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
            var ledzep = new ClassicRock();

            ledzep.Singer = new BandMember
            {
                Name = "Robert Plant",
                Crazy = false,
                DrugAddict=false,
                IsDead=false
            };
            
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
