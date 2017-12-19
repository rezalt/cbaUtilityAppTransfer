using Com.OneSignal;
using Com.OneSignal.Abstractions;
using Xamarin.Forms;

namespace cbaUtility
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new cbaUtility.MainPage();

            OneSignal.Current.StartInit("")
                .EndInit();

            if (!Helpers.Settings.GetMangelNotifications)
            {
                OneSignal.Current.SetSubscription(false);
            }
                

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
