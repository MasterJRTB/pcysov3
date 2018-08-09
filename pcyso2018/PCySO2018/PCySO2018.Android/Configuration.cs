using Xamarin.Forms;

[assembly: Dependency(typeof(PCySO2018.Droid.Configuration))]

namespace PCySO2018.Droid
{
    using SQLite.Net.Interop;
        
    public class Configuration : iConfiguration
    {
        private string Directorio;
        private ISQLitePlatform Plataforma;

        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio))
                {
                    Directorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return Directorio;
            }
        }

        public ISQLitePlatform plataforma
        {
            get
            {
                if (Plataforma == null)
                {
                    Plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return Plataforma;
            }
        }
    }
}