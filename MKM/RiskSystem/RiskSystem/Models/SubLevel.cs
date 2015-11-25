using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RiskSystem.Models
{
    public class SubLevel
    {
        [ScaffoldColumn(false)]
        public int SubLevelId { get; set; }
        [Display(Name = "Рівень")]
        public int LevelId { get; set; }
        [Required(ErrorMessage = "Введіть назву підсистеми")]
        [Display(Name = "Назва підсистеми")]
        public string SubLevelName { get; set; }
    }
}