using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ExamWork.Pages.Lecture
{
    public class DetailsLectureModel : PageModel
    {
        public readonly LectureServices LS;
        public DetailsLectureModel(LectureServices ls)
        {
            LS = ls;
        }

        public IActionResult OnGet(string topic)
        {
            LS.CurrentLecture = LS.LectureList[topic];
            return Page();
        }
    }
}
