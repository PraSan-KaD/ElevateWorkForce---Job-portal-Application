using System.ComponentModel.DataAnnotations;

namespace ElevateWorkForce.Models
{
    public class EmployerDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PrimaryContactPerson { get; set; }
        public string Email { get; set; }
        public string? UserId { get; set; }
    }

}
