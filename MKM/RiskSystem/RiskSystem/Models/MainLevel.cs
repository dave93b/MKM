using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace RiskSystem.Models
{
    public class MainLevel
    {
        [HiddenInput]
        public int LevelId { get; set; }
        [Required(ErrorMessage = "Введіть назву рівня")]
        [Display(Name = "Назва рівня")]
        public string LevelName { get; set; }
    }
}