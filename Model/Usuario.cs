using System.ComponentModel.DataAnnotations;

namespace OpenLims.Model
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        // [Required(ErrorMessage = "Name field is required.")]
        public string Name { get; set; }

        // [Required(ErrorMessage = "Username field is required.")]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public decimal Salary { get; set; }
        public string Currency { get; set; }
        public JsonContent Groups { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}