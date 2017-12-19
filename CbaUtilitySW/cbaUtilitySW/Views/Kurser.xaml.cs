using cbaUtility.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cbaUtility
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kurser : ContentPage
    {
        public Kurser()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.MainViewModel;

            var vm = BindingContext as MainViewModel;
            KurserListView.ItemsSource = vm.Reservationer;
        }

        private void KurserSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = BindingContext as MainViewModel;

            string searchText = KurserSearchBar.Text.ToLower();
            IEnumerable<cbaUtility.Reservation> result = vm.Reservationer.Where(i => i.columns[2].Contains(searchText));

            if (string.IsNullOrWhiteSpace(searchText))
                KurserListView.ItemsSource = vm.Reservationer;
            else if (result.Count() > 0)
                KurserListView.ItemsSource = result;
        }
    }
}