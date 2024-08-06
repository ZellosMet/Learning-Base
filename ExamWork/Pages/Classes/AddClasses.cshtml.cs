using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Classes
{
    public class AddClassesModel : PageModel
    {
        public ClassesServices CS;
        public string Message = String.Empty;
        public AddClassesModel(ClassesServices cs)
        {
            CS = cs;
        }
        public IActionResult OnGet() 
        {
            return Page();
        }
        
        public IActionResult OnPostAddClasses(string discipline, string date, string class_form)
        {
            if (CS.AddClasses(discipline, date, class_form)) Message = "Success!";
            else Message = "Not Success!";

            return Page();
        }
    }
}
