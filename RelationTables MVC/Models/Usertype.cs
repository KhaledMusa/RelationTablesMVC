using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace RelationTables_MVC.Models
{
    public class Usertype
    {
        public int UserTypeId { get; set; }
        [Display(Name ="User Type")]
        public string TypeDesc { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
