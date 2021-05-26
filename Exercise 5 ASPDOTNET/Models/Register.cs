using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_5_ASPDOTNET.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid Firstname"), Required, StringLength(50)]
        public string Firstname { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid Lastname"), Required, StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        public string Address { get; set; }
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Invalid must a number"), Required, StringLength(11)]
        public string ContactNumber { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid Gender"), Required, StringLength(50)]
        public string Gender { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid"), Required]
        public string EmailAddress { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Invalid School Campus"), Required, StringLength(50)]
        public string SchoolCampus { get; set; }
        [Required]
        public string Department { get; set; }
        
    }
}
