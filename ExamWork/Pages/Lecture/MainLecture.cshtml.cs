using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExamWork.Models;

namespace ExamWork.Pages.Lecture
{
    public class MainLectureModel : PageModel
    {
        public readonly LectureServices LS;
        public MainLectureModel(LectureServices ls)
        {
            LS = ls;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostDeleteLecture(string topic)
        {
            LS.DeleteLecture(topic);
            return Page();
        }
        public void OnPostEditLecture(string topic)
        {
            LS.CurrentLecture = LS.LectureList[topic];
        }

    }
}
