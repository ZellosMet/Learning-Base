using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExamWork.Models;

namespace ExamWork.Pages.Groups
{
    public class MainGroupModel : PageModel
    {
        public readonly GroupServices G;
        public MainGroupModel(GroupServices g)
        {
            G = g;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostDeleteGroup(string name)
        {
            G.DeleteGroup(name);
            return Page();
        }
        public void OnPostEditGroup(string name)
        {
            G.CurrentGroup = name;
        }

    }
}
