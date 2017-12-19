using cbaUtility.ViewModels;

namespace cbaUtility
{
    // Vi kan også bruge den her til at give en "mock" viewmodel tilbage.
    public static class ViewModelLocator
    {
        private static MainViewModel _myMainViewModel = new MainViewModel();
        public static MainViewModel MainViewModel
        {
            get
            {
                return _myMainViewModel;
            }
        }
    }
}
