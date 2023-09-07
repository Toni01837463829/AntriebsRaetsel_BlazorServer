using Model.Entities;

namespace GUI
{
    public class UserInformation
    {
        public string Name { get; set; } = "Guest";
        public int CurrentScore { get; set; } = 0;
        public List<int> previousQuestionIDs { get; set; } = new List<int>();
        public int MomentaryHighScore { get; set; } = 0; //just used to prevent uploading every score just the highest from each user 


        public void Reset ()
        {
            Name = "Guest";
            CurrentScore = 0;
            previousQuestionIDs = new List<int>();
            MomentaryHighScore = 0;
        }

        /// <summary>
        /// Execute when the player has answered a wrong Questions
        /// </summary>
        public bool Lost()
        {
            previousQuestionIDs.Clear();
            if(CurrentScore > MomentaryHighScore)
            {
                MomentaryHighScore = CurrentScore;

                //Change Highscore in DB
            }

            CurrentScore = 0;
        }
    }
}
