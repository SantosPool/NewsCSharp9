using NewsCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCSharp.Commons
{
    internal class PopulationCommon
    {
        public static string SayPopulation(int totPopulation) =>
            totPopulation switch
            {
                int t when totPopulation > 1000 => "greather than 1000",
                int t when totPopulation < 1000 && totPopulation >= 100 => "smaller than 1000",
                int _ => " smaller than 100 ",

                // _ => throw new Exception($"Not know int Type {totPopulation}")
            };

        public static string SayPopulationV2(object place) =>
            place switch
            {
                Place t => t.Population switch
                {
                    > 1000000 => "Great orc horde",
                    <= 1000000 and >= 100000 => "orc horde",
                    < 10000 and >= 100 => "a few orcs",
                    _ => "orcs"
                },
                not null => throw new ArgumentException($"not know place type {nameof(place)} "),
                null => throw new ArgumentNullException("null value", nameof(place))
            };

        public static bool  ValidateModel(object place)
        {
            if(place is not Place)
            {
                return false;
            }
            return true;
        }
    }
}
