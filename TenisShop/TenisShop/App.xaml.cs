using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TenisShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjYyMDQ2QDMxMzgyZTMxMmUzMG9CWlZNby9PemJ2S08zaWgxb3BSTjVrWno5K2tQNFlXQWJXdlg3QWRRSmc9");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
