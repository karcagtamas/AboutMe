namespace AboutMe.Models
{
    public class NavigatorElement
    {
        public string Name { get; set; }
        public string Path { get; set; }


        public bool IsCurrent(string path)
        {
            return path == this.Path;
        }
    }
}