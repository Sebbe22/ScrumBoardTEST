using ScrumBoard.MockData;
using ScrumBoardLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumBoard.Services
{
    public class UserStoryService
    {
        
        private List<UserStory> _userStories = new List<UserStory>();

        /// <summary>
        /// Constructor that adds the mockdata to the list which the rest of the program uses
        /// </summary>
        public UserStoryService()
        {
            _userStories = MockUserStories.GetMockUserStories();
        }

        /// <summary>
        /// A method for getting all userstories in the list
        /// </summary>
        /// <returns> returns a list of userstories </returns>
        public List<UserStory> GetUserStories()
        {
            return _userStories;
        }

        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in _userStories)
            {
                if (userStory.Id == id)
                    return userStory;
            }
            return null;
        }

        public UserStory DeleteUserStory(int userstoryId)
        {
            UserStory userstoryToBeDeleted = null;
            foreach (UserStory us in _userStories)
            {
                if (us.Id == userstoryId)
                {
                    userstoryToBeDeleted = us;
                    break;
                }
            }
            if (userstoryToBeDeleted != null)
            {
                _userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }
    }
}
