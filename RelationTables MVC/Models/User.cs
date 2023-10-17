using System.ComponentModel.DataAnnotations;

namespace RelationTables_MVC.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name ="User Name")]
        public string  UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public Usertype UserType { get; set; }
    }
}
