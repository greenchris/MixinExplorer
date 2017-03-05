using System.Collections.Generic;
using System.Linq;
using MixinExplorer.Enum;

namespace MixinExplorer.Model
{
    public class NinjaVillage
    {
        private IEnumerable<Ninja> _ninjas;

        public NinjaVillage()
        {
            AssembleCapability();
        }

        public Ninja ProvideNinja(SkillRankEnum requestedRank) =>
            _ninjas.FirstOrDefault(n => n.SkillRank == requestedRank);

        #region private utils
        private void AssembleCapability()
        {
            _ninjas = new List<Ninja>()
            {
                new Ninja
                {
                    Name = "Kimimaro",
                    Weapon = "Shuriken",
                    SkillRank = SkillRankEnum.B,
                    PowerLevel = 26,
                    NumWins = 341,
                    NumDefeats = 7,
                    IsOnMission = false,
                    Techniques = new List<string> { "Fire Blast", "Rapid Lightning" }
                },
                new Ninja
                {
                    Name = "Hidan",
                    Weapon = "Shuriken",
                    SkillRank = SkillRankEnum.C,
                    PowerLevel = 12,
                    NumWins = 139,
                    NumDefeats = 76,
                    IsOnMission = false,
                    Techniques = new List<string> { "Curse Almighty", "Wind Bullets" }
                },
                new Ninja
                {
                    Name = "Kakuzu",
                    Weapon = "Shuriken",
                    SkillRank = SkillRankEnum.A,
                    PowerLevel = 34,
                    NumWins = 500,
                    NumDefeats = 2,
                    IsOnMission = false,
                    Techniques = new List<string> { "Wind Blade", "Water Vortex" }
                }
            };
        }
        #endregion
    }
}
