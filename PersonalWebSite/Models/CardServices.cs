namespace PersonalWebSite.Models
{
    public class CardServices
    {
        public static List<CardServices> cardServices = new List<CardServices>()
        {
            new CardServices(1,"fa-sharp fa-solid fa-pen-to-square","Script Writing","her is the text for division Writing i will present in my Projects Cources in university"),
            new CardServices(2,"fa-solid fa-video","Script Writing","her is the text for division Writing i will present in my Projects Cources in university"),
            new CardServices(3,"fa-solid fa-chalkboard-user","Script Writing","her is the text for division Writing i will present in my Projects Cources in university"),
            new CardServices(4,"fa-solid fa-chalkboard-user","Script Writing","her is the text for division Writing i will present in my Projects Cources in university"),
        };
        public CardServices(int iD, string icon, string title, string description)
        {
            ID = iD;
            this.icon = icon;
            this.title = title;
            this.description = description;
        }

        public int ID { get; set; }
        public string icon { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
