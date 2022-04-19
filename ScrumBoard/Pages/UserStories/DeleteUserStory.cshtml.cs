using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumBoard.Services;
using ScrumBoardLib.Model;

namespace ScrumBoard.Pages.UserStories
{
    public class DeleteUserStoryModel : PageModel
    {

        [BindProperty]
        public UserStory UserStory { get; set; }

        private UserStoryService userStoryService;

        public DeleteUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }


        public void OnGet(int id)
        {
            UserStory = userStoryService.GetUserStory(id);
        }

        public IActionResult OnPost(int id)
        {
            UserStory deletedUserStory = userStoryService.DeleteUserStory(id);
            return RedirectToPage("Index");
        }
    }
}
