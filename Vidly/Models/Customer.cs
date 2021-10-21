using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubsctibedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; } // Navigation Property
        public byte MembershipTypeId { get; set; } // Foreign Key --> The same type with Id in MembershipType POCO and the name (POCO + Id) i.e. MembershipTypeId
    }
}
