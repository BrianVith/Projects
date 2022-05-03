using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SurfsUpIdentity.Enums
{
    public enum Conditions
    {
        [Display(Name = "Brugt")]
        Brugt,
        [Display(Name = "God")]
        God,
        [Display(Name = "Ny")]
        Ny
    };
}