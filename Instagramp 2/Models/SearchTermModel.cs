namespace Instagramp_2.Models
{
    public class SearchTermModel
    {
        public string name { get; set; }
        public string description { get; set; }
        public string imgURL { get; set; }
        public string actionName { get; set; }
        public string controllerName { get; set; }

        public SearchTermModel(string name, string description, string imgURL, string actionName, string controllerName)
        {
            this.name = name;
            this.description = description;
            this.imgURL = imgURL;
            this.actionName = actionName;
            this.controllerName = controllerName;
        }
        public SearchTermModel()
        {
        }
    }
}
