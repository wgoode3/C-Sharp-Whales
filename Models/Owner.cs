using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Whales.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId {get;set;}
        [Required]
        public string Name {get;set;}

        public List<Pet> OwnedPets {get;set;}
    }
}