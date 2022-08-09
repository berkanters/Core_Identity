using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoreIdentity102.ViewModel
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "{0} Role name is required"), DisplayName("Role Name")]

        public string Name { get; set; }
    }
}
