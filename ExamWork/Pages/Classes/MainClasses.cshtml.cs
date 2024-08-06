using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExamWork.Models;

namespace ExamWork.Pages.Classes
{
    public class MainClassesModel : PageModel
    {
        public readonly ClassesServices CS;
        public MainClassesModel(ClassesServices cs)
        {
            CS = cs;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostDeleteClasses(string discipline)
        {
            CS.DeleteClasses(discipline);
            return Page();
        }
        public void OnPostEditClasses(string discipline)
        {
            CS.CurrentClasses = CS.ClassesList[discipline];
        }

    }
}
