using ExamWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamWork.Pages.Groups
{
    public class AddGroupModel : PageModel
    {
        public GroupServices G;
        public string Message = String.Empty;
        public AddGroupModel(GroupServices g)
        {
            G = g;
        }
        public IActionResult OnGet() 
        {
            return Page();
        }
        
        public IActionResult OnPostAddGroup(string name)
        {
            G.AddGroup(name);
            Message = "Success!";
            return Page();
        }
    }
}
