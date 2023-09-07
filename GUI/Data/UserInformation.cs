using Model.Entities;

namespace GUI
{
    public class UserInformation
    {
        public string Name { get; set; } = "Guest";
        public int CurrentScore { get; set; } = 0;
        public List<int> previousQuestionIDs { get; set; } = new List<int>();
        public int MomentaryHighScore { get; set; } = 0; //just used to prevent uploading every score just the highest from each user 
    }
}
