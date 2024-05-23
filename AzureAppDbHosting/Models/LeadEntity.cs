using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AzureAppDbHosting.Models
{
    public class LeadEntity
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date")]

        public DateTime LeadDate { get; set; }

        public string OwnerWalker { get; set; }

        public string Name { get; set; }

        public string Mobile {  get; set; }

        public string Email { get; set; }
    }
}
