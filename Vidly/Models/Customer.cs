using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubsctibedToNewsLetter { get; set; }

        [Required(ErrorMessage = "The Memebership Type is required")]
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; } // Navigation Property

        public byte MembershipTypeId { get; set; } // Foreign Key --> The same type with Id in MembershipType POCO and the name (POCO + Id) i.e. MembershipTypeId
    }
}
