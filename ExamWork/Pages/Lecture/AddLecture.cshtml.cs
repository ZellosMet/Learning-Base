using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Lecture
{
    public class AddLectionModel : PageModel
    {
        public LectureServices LS;
        public GroupServices G;

        public string Message = String.Empty;
        public AddLectionModel(LectureServices ls, GroupServices g)
        {
            LS = ls;
            G = g;
        }
        public IActionResult OnGet() 
        {
            return Page();
        }
        
        public IActionResult OnPostAddLecture(string topic, string description, string type, string date)
        {
            if(LS.AddLecture(topic, description, type, date)) Message = "Success!";
            else Message = "Success!";
            return Page();
        }
    }
}
