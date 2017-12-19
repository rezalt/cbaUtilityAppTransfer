using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace cbaUtility.Views
{
    public partial class FjernMangelSuccessPopupPage : PopupPage
    {
        public FjernMangelSuccessPopupPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            HidePopup();
        }

        private async void HidePopup()
        {
            await Task.Delay(3000);
            await PopupNavigation.RemovePageAsync(this);
        }
    }
}
