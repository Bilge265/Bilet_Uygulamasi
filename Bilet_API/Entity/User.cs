using System.ComponentModel.DataAnnotations;

namespace Bilet_API.Entity
{
    public class User: BaseEntity
    {
        [Key] public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
