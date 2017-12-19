using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using cbaUtility.ViewModels;

namespace cbaUtility.Views
{
    public partial class MangelPopupPage : PopupPage
    {

        internal NewMangelViewModel Nmvm { get => nmvm; set => nmvm = value; }
        NewMangelViewModel nmvm;

        public MangelPopupPage()
        {
            InitializeComponent();
            Nmvm = new NewMangelViewModel();
            BindingContext = ViewModelLocator.MainViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            FrameContainer.HeightRequest = -1;

            CloseImage.Rotation = 30;
            CloseImage.Scale = 0.3;
            CloseImage.Opacity = 0;

            TilføjButton.Scale = 0.3;
            TilføjButton.Opacity = 0;

            BeskrivelseEditor.TranslationX = -10;
            BeskrivelseEditor.Opacity = 0;

            BeskrivelseEditorLabel.Opacity = 0;
        }

        protected async override Task OnAppearingAnimationEnd()
        {
            var translateLength = 400u;

            await Task.WhenAll(
                (new Func<Task>(async () =>
                {
                    await Task.Delay(200);
                    await Task.WhenAll(
                        BeskrivelseEditor.TranslateTo(0, 0, easing: Easing.SpringOut, length: translateLength),
                        BeskrivelseEditor.FadeTo(1),
                        BeskrivelseEditorLabel.TranslateTo(0, 0, easing: Easing.SpringOut, length: translateLength),
                        BeskrivelseEditorLabel.FadeTo(1));

                }))());

            await Task.WhenAll(
                CloseImage.FadeTo(1),
                CloseImage.ScaleTo(1, easing: Easing.SpringOut),
                CloseImage.RotateTo(0),
                TilføjButton.ScaleTo(1),
                TilføjButton.FadeTo(1));
        }

        protected async override Task OnDisappearingAnimationBegin()
        {
            var taskSource = new TaskCompletionSource<bool>();

            var currentHeight = FrameContainer.Height;

            await Task.WhenAll(
                BeskrivelseEditor.FadeTo(0),
                BeskrivelseEditorLabel.FadeTo(0),
                TilføjButton.FadeTo(0));

            FrameContainer.Animate("HideAnimation", d =>
            {
                FrameContainer.HeightRequest = d;
            },
            start: currentHeight,
            end: 170,
            finished: async (d, b) =>
            {
                await Task.Delay(300);
                taskSource.TrySetResult(true);
            });

            await taskSource.Task;
        }

        private async void OnTilføj(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(BeskrivelseEditor.Text))
            {
                await DisplayAlert("Mangler detaljer", "Du skal tilføje en beskrivelse, før du opretter en ny mangel.", "OK!");
            }
            else
            {

                var _lokale = LokaleLabel.Text;
                var _beskrivelse = BeskrivelseEditor.Text;
                var _lysMangel = LysMangel.IsToggled;
                var _projekterMangel = ProjekterMangel.IsToggled;
                var _bordeMangel = BordeMangel.IsToggled;
                var _stoleMangel = StoleMangel.IsToggled;

                var loadingPage = new LoadingPopupPage();
                await Navigation.PushPopupAsync(loadingPage);


                if (
                    await nmvm.NewMangelAsync
                        (
                            _lokale,
                            _beskrivelse,
                            "Lav",
                            _lysMangel,
                            _projekterMangel,
                            _bordeMangel,
                            _stoleMangel
                        )
                    )
                {
                    await Task.Delay(200);
                    await Navigation.RemovePopupPageAsync(loadingPage);
                    await Navigation.RemovePopupPageAsync(this);
                    await Navigation.PushPopupAsync(new MangelSuccessPopupPage());
                }
                else
                {
                    await Task.Delay(200);
                    await Navigation.RemovePopupPageAsync(loadingPage);
                    await Navigation.RemovePopupPageAsync(this);
                    await Navigation.PushPopupAsync(new MangelFailurePopupPage());
                }

            }
        }


        private void OnCloseButtonTapped(object sender, EventArgs e)
        {
            CloseAllPopup();
        }

        protected override bool OnBackgroundClicked()
        {
            CloseAllPopup();
            return false;
        }

        private async void CloseAllPopup()
        {
            await Navigation.PopAllPopupAsync();
        }
    }
}
