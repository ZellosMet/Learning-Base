using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Groups
{
    public class EditGroupModel : PageModel
    {
        public GroupServices G;
        public string Message = String.Empty;
        public EditGroupModel(GroupServices g)
        {
            G = g;
        }
        public IActionResult OnGet(string name)
        {
            G.CurrentGroup = name;
            return Page();
        }
        public IActionResult OnPostEditGroup(string name)
        {
            if (G.DeleteGroup(G.CurrentGroup))
            { 
                G.AddGroup(name);
                G.CurrentGroup = name;
                Message = "Success!";
            }
            else Message = "Not Success!";
            return Page();
        }
    }
}
