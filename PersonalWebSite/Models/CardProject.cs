namespace PersonalWebSite.Models
{
    public class CardProject
    {
        public int id { get; set; }
        public string image { get; set; }
        public string projectCatigory { get; set; }
        public string projectTitle { get; set; }
        public DetailesC detailes { get; set; }

        public static List<CardProject> cardProjects = new List<CardProject>()
        {
            new CardProject(1,"images/img2.jpg","Test System Using Dart Language and Flutter FrameWork","Test System",DetailesC.detailes[0]),
            new CardProject(2,"images/t1.png","this project provide Data for All Action in Prison and Persons ","Prison Manager",DetailesC.detailes[1]),
        };

        public CardProject(int iD, string image, string projectCatigory, string projectTitle, DetailesC detailes)
        {
            id = iD;
            this.image = image;
            this.projectCatigory = projectCatigory;
            this.projectTitle = projectTitle;
            this.detailes = detailes;
        }
    }
}
