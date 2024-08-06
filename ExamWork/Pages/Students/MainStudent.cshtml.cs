using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExamWork.Models;

namespace ExamWork.Pages.Students
{
    public class MainStudentModel : PageModel
    {
        public readonly StudentsServices SS;
        public MainStudentModel(StudentsServices ss)
        {
            SS = ss;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostDeleteStudent(int stud_id)
        {
            SS.DeleteStudent(stud_id);
            return Page();
        }
        public void OnPostEditstudent(int stud_id)
        {
            SS.CurrentStudent = SS.StudentList[stud_id];
        }

    }
}
