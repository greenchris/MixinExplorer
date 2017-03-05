using System.Collections.Generic;
using MixinExplorer.Mixins;
using MixinExplorer.Enum;

namespace MixinExplorer.Model
{
    /// <summary>
    /// Ninja is being supplemented with two mixins
    /// In other words, two sets of modular functionality are being mixed into Ninja
    /// => we are tagging functionality on essentially!
    /// </summary>
    public class Ninja : JsonSerializableMixin, DisposableMixin
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public SkillRankEnum SkillRank { get; set; }
        public int PowerLevel { get; set; }
        public int NumWins { get; set; }
        public int NumDefeats { get; set; }
        public List<string> Techniques { get; set; }
        public bool IsOnMission { get; set; }
    }
}