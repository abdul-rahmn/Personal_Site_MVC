namespace PersonalWebSite.Models
{
    public class DetailesC
    {
        public static List<DetailesC> detailes = new List<DetailesC>()
        {
            new DetailesC(1,"Test System","i created this project in the in my study in university the project it is Test System for Manage the Tests,uncluder part Admin and part user(Student) the system have timer for end test and after End the test the system view the results and the Question that True or False and Detailes Questions and Save it in DataBase.","Dart","Flutter","Sqlite","FastAPI",new List<string>(){
            "test-system/1.png",
            "test-system/2.png",
            "test-system/3.png",
            "test-system/4.png",
            "test-system/5.png",
            "test-system/6.png",
            "test-system/7.png",
            "test-system/8.png",
            "test-system/9.png",
            "test-system/10.png",
            "test-system/11.png",
            "test-system/12.png",
            "test-system/13.png",
            "test-system/14.png",
            "test-system/15.png",
            "test-system/16.png",
            "test-system/17.png",
            "test-system/18.png",
            "test-system/19.png",
            "test-system/20.png",
            "test-system/21.png",
            "test-system/22.png",
            "test-system/23.png",
            "test-system/24.png",
            "test-system/25.png",
            "test-system/26.png",
            "test-system/27.png",
            "test-system/28.png",
        }),
            new DetailesC(2,"Prison Manager","i created this project in the in my study in university the project it is Test System for Manage the Tests,uncluder part Admin and part user(Student) the system have timer for end test and after End the test the system view the results and the Question that True or False and Detailes Questions and Save it in DataBase.","Python","","Sqlite3","FastAPI",new List<string>(){
            "prison/1.png",
            "prison/2.png",
            "prison/3.png",
            "prison/4.png",
            "prison/5.png",
            "prison/6.png",
            "prison/7.png",
            "prison/8.png",
            "prison/9.png",
            "prison/10.png",
            "prison/11.png",
            "prison/12.png",
            "prison/13.png",
            "prison/14.png",
            "prison/15.png",
            "prison/16.png",
            "prison/17.png",
            "prison/18.png",
            "prison/19.png",
            "prison/20.png",
            "prison/21.png",
            "prison/22.png",
            "prison/23.png",
            "prison/24.png",
            "prison/25.png",
            "prison/26.png",
        }),
        };

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string lang { get; set; }
        public string frameWork { get; set; }
        public string dataBase { get; set; }
        public string api { get; set; }
        public List<string> images = new List<string>();

        public DetailesC(int id, string title, string description, string lang, string frameWork, string dataBase, string api, List<string> images)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.lang = lang;
            this.frameWork = frameWork;
            this.dataBase = dataBase;
            this.api = api;
            this.images = images;
        }
    }
}
