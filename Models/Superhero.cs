using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero_Project.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Superhero Name")]
        public string SuperheroName { get; set; }

        [Display(Name = "Alter Ego")]
        public string AlterEgo { get; set; }
        [Display(Name = "Primary Ability")]
        public string PrimaryAbility { get; set; }
        [Display(Name = "Secondary Ability")]
        public string SecondaryAbility { get; set; }
        [Display(Name = "Catch Phrase")]
        public string CatchPhrase { get; set; }
    }
}