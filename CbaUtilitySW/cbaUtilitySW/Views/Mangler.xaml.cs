
using cbaUtility.Views;
using Rg.Plugins.Popup.Extensions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cbaUtility
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mangler : ContentPage
    {

        public Mangler()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.MainViewModel;
        }

        private async void ManglerListView_ItemTappedAsync(object sender, ItemTappedEventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            var vm = BindingContext as ViewModels.MainViewModel;
            var mangel = e.Item as Mangel;

            if (await DisplayAlert("Slet mangel", "Vil du slette denne mangel?", "Slet", "Annuller"))
            {
                await Navigation.PushPopupAsync(loadingPage);

                if(await vm.DeleteMangelAsync(mangel))
                {
                    await Task.Delay(200);
                    await Navigation.RemovePopupPageAsync(loadingPage);
                    await Navigation.PushPopupAsync(new FjernMangelSuccessPopupPage());
                }
                else
                {
                    await Task.Delay(200);
                    await Navigation.RemovePopupPageAsync(loadingPage);
                    await Navigation.PushPopupAsync(new FjernMangelFailurePopupPage());
                }
            }
        }
    }

}
