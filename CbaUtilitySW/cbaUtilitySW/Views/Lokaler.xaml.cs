using cbaUtility.ViewModels;
using cbaUtility.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cbaUtility 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lokaler : ContentPage
    {

        public Lokaler() 
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.MainViewModel;
        }

        public void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ViewModelLocator.MainViewModel;

            if(!vm.lokaleModalOpen)
            {
                vm.SelectedLokale = e.Item as Lokale;
                vm.SetLokaleMangler();
                NavigateTo();
            }

            // bool prevents multiple modals from opening at the same time.
             vm.lokaleModalOpen = true;
         
        }

        void NavigateTo()
        {
          
            var n = new NavigationPage(new LokaleDetaljer());
            Navigation.PushModalAsync(n);
        }
    }
}