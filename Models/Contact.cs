using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace comp2139_lab3_wednesday.Models
{
    public class Contact
    {

        public int ContactId { get; set; }

        [Required(ErrorMessage ="Please Enter a valid firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please Enter a valid lastname")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please Enter a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter a valid email")]
        public string Email { get; set; }

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }
        [Range(1,10,ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string slug => Firstname?.Replace(' ', '-').ToLower()
            + "-" + Lastname?.Replace(' ', '-').ToLower();


    }
}
