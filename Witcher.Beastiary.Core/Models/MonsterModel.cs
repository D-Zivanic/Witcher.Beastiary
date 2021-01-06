using System;

namespace Witcher.Beastiary.Core.Models
{
    public class MonsterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Weakness { get; set; }
    }
}
