namespace Tutorial2.Models
{
    public class MyModel
    {
        public string Hello { get; set; }
        public string Image { get; set; }
        public string Welcome { get; set; }

        public MyModel()
        {
            Hello = "Hello, World!";
            Image = "dotnet_bot.png"; 
            Welcome = "Welcome to .NET Multi-platform App UI";
        }
    }
}