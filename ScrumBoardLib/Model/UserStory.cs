using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib.Model
{
    public class UserStory
    {
        
        public int Id { get; set; }
        public int StoryPoints { get; set; }
        public int BuisnessValue { get; set; }

        private string _Title;
        private string _Description;

        public string Description
        {
            get => _Description;
            set
            {
                DescriptionCheck(value);
                _Description = value;
            }

        }

        public string Title
        {
            get => _Title;
            set
            {
                TitleCheck(value);
                _Title = value;
            }
        }

        private static int NextId = 1;

        public UserStory()
        {
            Title = "Dummy";
            Description = "Dummy";
        }

        public UserStory(string title, string descrip)
        {
            Title = title;
            Description = descrip;
            Id = NextId++;
            StoryPoints = 0;
            BuisnessValue = 0;
        }

        public override string ToString()
        {
            return ($"Id = {Id}, Title = {Title}, Description = {Description}, StoryPoints = {StoryPoints}, Buisness Value = {BuisnessValue}");
        }

        /// <summary>
        /// Checks if the title is less than 3 characters and if it is throws an exception with an "error" message
        /// </summary>
        /// <param name="title"> the string you want to check the length of </param>
        public void TitleCheck(string title)
        {
            if (title.Length < 3)
            {
                throw new ArgumentException("Titlen skal være læmgere end 3 tegn... titlen var sat til =" + title);
            }
        }

        /// <summary>
        /// Checks if the description is longer less than 10 characters and if it is throws an exception with an "error" message
        /// </summary>
        /// <param name="desc"> the string you want to check if its longer than 10 characters </param>
        public void DescriptionCheck(string desc)
        {
            if (desc.Length < 5)
            {
                throw new ArgumentException("Description skal være længere end 10 tegn... description var sat til =" + desc);
            }
        }

        /// <summary>
        /// makes sure the StoryPoints value isnt less than 0 and throws and exeption with an "error" message if it is
        /// </summary>
        /// <param name="point"> the story points value u want to check </param>
        public void StoryPointsCheck(int point)
        {
            if (point < 0)
            {
                throw new ArgumentException("StoryPoints må ikke være negative... storypoint var sat til =" + point);
            }
        }

        /// <summary>
        /// checks that the value is between 0-10 and throws an error message if the value is outside the bonds
        /// </summary>
        /// <param name="point"> the value you want to check </param>
        public void BuissnessValueCheck(int point)
        {
            if (point > 10 || point < 0)
            {
                throw new ArgumentException("BuisnessValue skal være imellem 0 og 10... BuisnessValue var sat til =" + point);
            }
        }
    }
}
