using Rg.Plugins.Popup.Extensions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cbaUtility.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LokaleDetaljer : ContentPage
    {
        private MangelPopupPage _mangelPopup;

        public LokaleDetaljer()
        {
            InitializeComponent();
            var vm = ViewModelLocator.MainViewModel;

            var backItem = new ToolbarItem
            {
                Text = "Back"
            };

            this.ToolbarItems.Add(backItem);
            backItem.Clicked += (object sender, System.EventArgs e) =>
            {
                vm.lokaleModalOpen = false;
                Navigation.PopModalAsync();
            };

            _mangelPopup = new MangelPopupPage();


            BindingContext = ViewModelLocator.MainViewModel;

           
        }

        private async void OnOpenPupup(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(_mangelPopup);
        }

        protected override bool OnBackButtonPressed()
        {
            var vm = ViewModelLocator.MainViewModel;
            vm.lokaleModalOpen = false;
            Navigation.PopModalAsync();
            return true;
        }
    }

   
    
}