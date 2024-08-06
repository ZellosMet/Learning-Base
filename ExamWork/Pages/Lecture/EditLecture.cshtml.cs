using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Lecture
{
    public class EditLectureModel : PageModel
    {
        public LectureServices LS;
        public GroupServices G;
        public string Message = String.Empty;
        public EditLectureModel(LectureServices ls, GroupServices g)
        {
            LS = ls;
            G = g;
        }
        public IActionResult OnGet(string topic)
        {
            LS.CurrentLecture = LS.LectureList[topic];
            return Page();
        }
        public IActionResult OnPostEditLecture(string topic, string description, string type, string date)
        {
            if (LS.DeleteLecture(LS.CurrentLecture.Topic))
            {
                if (LS.AddLecture(topic, description, type, date))
                { 
                    LS.CurrentLecture = LS.LectureList[topic];
                    Message = "Success!";
                }
                else Message = "Not Success!";
            }
            else Message = "Not Success!";
            return Page();
        }
    }
}
