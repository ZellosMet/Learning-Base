using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Classes
{
    public class EditClassesModel : PageModel
    {
        public ClassesServices CS;
        public string Message = String.Empty;
        public EditClassesModel(ClassesServices cs)
        {
            CS = cs;
        }
        public IActionResult OnGet(string discipline)
        {
            CS.CurrentClasses = CS.ClassesList[discipline];
            return Page();
        }
        public IActionResult OnPostEditClasses(string discipline, string date, string class_form)
        {
            if (CS.DeleteClasses(CS.CurrentClasses.Discipline)) 
            {
                if (CS.AddClasses(discipline, date, class_form))
                { 
                    CS.CurrentClasses = CS.ClassesList[discipline];
                    Message = "Success!";
                }
                else Message = "Not Success!";               
            }
            else Message = "Not Success!";
            return Page();
        }
    }
}
