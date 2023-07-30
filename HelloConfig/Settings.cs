namespace HelloConfig
{
    public class Settings
    {
        public IConfiguration config { get; set; }
        public Settings() 
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddInMemoryCollection(new Dictionary<string, string> 
            { { "Country", "Россия" }, { "City", "Москва" } });

            config = configurationBuilder.Build();
        }
        public Settings(string rootPath)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(rootPath);
            configurationBuilder.AddJsonFile("appsettings.json");

            config = configurationBuilder.Build();
        }
    }
}
