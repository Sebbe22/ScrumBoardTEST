using ScrumBoardLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumBoard.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create", "jeg vil gerne oprette nye storys"),
            new UserStory("Delete", "jeg vil gerne slette storys"),
            new UserStory("Edit", "jeg vil gerne redigerer en story"),
            new UserStory("Move", "jeg vil gerne kunne flytte en story") 
        };

        public static List<UserStory> GetMockUserStories()
        {
            return userStories;
        }
    }

}
