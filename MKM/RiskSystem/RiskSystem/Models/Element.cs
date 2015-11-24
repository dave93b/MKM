using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RiskSystem.Models
{
    public class Element
    {
        [ScaffoldColumn(false)]
        public int ElementId { get; set; }
        [Display(Name = "Підрівень")]
        public int SubLevelId { get; set; }
        [Required(ErrorMessage = "Введіть назву елемента")]
        [Display(Name = "Назва елемента")]
        public string ElementName { get; set; }
    }
}