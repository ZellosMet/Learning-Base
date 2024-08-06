using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Students
{
    public class AddStudentModel : PageModel
    {
        public StudentsServices SS;
        public GroupServices G;
        public string Message = String.Empty;
        public AddStudentModel(StudentsServices ss, GroupServices g)
        {
            SS = ss;
            G = g;
        }
        public IActionResult OnGet() 
        {
            return Page();
        }
        
        public IActionResult OnPostAddStudent(string first_name, string last_name, string sur_name, int stud_id, bool group_leader, string group)
        {
            if(SS.AddStudent(first_name, last_name, sur_name, stud_id, group_leader, group)) Message = "Success!";
            else Message = "Success!";
            return Page();
        }
    }
}
