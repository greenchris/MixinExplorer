using System;
using MixinExplorer.Model;
using MixinExplorer.Enum;
using MixinExplorer.Mixins.Core;

namespace MixinExplorer
{
    public class Program
    {
        public void Main(string[] args)
        {
            var shinobiX = new NinjaVillage().ProvideNinja(SkillRankEnum.A);

            /* 1. serialize */
            //Console.WriteLine(shinobiX.ToJson());
            //Console.WriteLine($"Serialization to {shinobiX.GetType()} complete");

            /* 2. deserialize */
            //var json = 
            //    @"{
            //        'Name': 'Kimimaro',
            //        'Weapon': 'Shuriken',
            //        'SkillRank': 'B',
            //        'PowerLevel': 26,
            //        'NumWins': 341,
            //        'NumDefeats': 7,
            //        'Techniques': ['Fire Blast','Rapid Lightning'],
            //        'IsOnMission': false
            //    }";
            //
            //var recoveredShinobi = new Ninja();
            //recoveredShinobi.FromJson<Ninja>(json);
            //Console.WriteLine($"Deserialization of {json} \n to {recoveredShinobi.GetType()} complete");

            /* 3. dispose of shinobi's specified unmanaged code (for sake of example, just feed dud objs) */
            //shinobiX.Dispose(true, new object [] { new object(), new object() });

            Console.ReadKey();
        }
    }
}
