using System;
using System.ComponentModel.DataAnnotations;

namespace Witcher.Beastiary.Core.Models
{
    public class MonsterModel
    {
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        public string Weakness { get; set; }
    }
}
