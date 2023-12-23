using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    internal class UserRegistrationValidation
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string pasword { get; set; }

        [Required(ErrorMessage = "User Role is Required")]
        public string role { get; set; }
    }

    [MetadataType(typeof(UserRegistrationValidation))]
    public partial class tbl_user
    {

    }
}
