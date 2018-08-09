namespace PCySO2018
{
    using SQLite.Net.Interop;

    public interface iConfiguration
    {
        string directorio { get; }
        ISQLitePlatform plataforma { get; }
        
    }
}
