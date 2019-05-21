using System;
using System.ComponentModel.DataAnnotations;

namespace Whales.Models
{
    public class Pet
    {
        [Key]
        public int PetId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Species {get;set;}
        public int OwnerId {get;set;}
        public Owner PetOwner {get;set;}
    }
}