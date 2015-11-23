using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RiskSystem.Models
{
    public class SubLevel
    {
        [HiddenInput]
        public int SubLevelId { get; set; }
        [Display(Name = "Рівень")]
        public int LevelId { get; set; }
        [Required(ErrorMessage = "Введіть назву підрівня")]
        [Display(Name = "Назва підрівня")]
        public string SubLevelName { get; set; }
    }
}