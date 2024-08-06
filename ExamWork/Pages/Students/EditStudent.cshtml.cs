using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Students
{
    public class EditStudentModel : PageModel
    {
        public StudentsServices SS;
        public GroupServices G;
        public string Message = String.Empty;
        public EditStudentModel(StudentsServices ss, GroupServices g)
        {
            SS = ss;
            G = g;
        }
        public IActionResult OnGet(int stud_id)
        {
            SS.CurrentStudent = SS.StudentList[stud_id];
            return Page();
        }
        public IActionResult OnPostEditStudent(string first_name, string last_name, string sur_name, int stud_id, bool group_leader, string group)
        {
            if (SS.DeleteStudent(SS.CurrentStudent.StudentId))
            {
                if (SS.AddStudent(first_name, last_name, sur_name, stud_id, group_leader, group))
                { 
                    SS.CurrentStudent = SS.StudentList[stud_id];
                    Message = "Success!";
                }
                else Message = "Not Success!";
            }
            else Message = "Not Success!";
            return Page();
        }
    }
}
