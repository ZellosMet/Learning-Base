using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ExamWork.Pages.Students
{
    public class DetailsStudentModel : PageModel
    {
        public readonly StudentsServices SS;
        public DetailsStudentModel(StudentsServices ss)
        {
            SS = ss;
        }

        public IActionResult OnGet(int stud_id)
        {
            SS.CurrentStudent = SS.StudentList[stud_id];
            return Page();
        }
    }
}
