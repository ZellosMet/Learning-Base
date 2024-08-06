using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ExamWork.Pages.Classes
{
    public class DetailsClassesModel : PageModel
    {
        public readonly ClassesServices CS;
        public DetailsClassesModel(ClassesServices cs)
        {
            CS = cs;
        }

        public IActionResult OnGet(string discipline)
        {
            CS.CurrentClasses = CS.ClassesList[discipline];
            return Page();
        }
    }
}
