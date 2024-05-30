using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AzureAppDbHosting.Models
{
    public class DogOwner
    {
        [Key]
        public int OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public int DogAge { get; set; }
        public string Address { get; set; }
    }
}
