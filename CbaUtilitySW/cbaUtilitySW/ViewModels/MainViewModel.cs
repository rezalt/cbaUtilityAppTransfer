using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using System.ComponentModel;
using System.Net.Http;
using cbaUtility.Data;
using System.Linq;
using System.Globalization;
using Com.OneSignal;

namespace cbaUtility.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region URL's
        string _getManglerURL = "http://  /SkoleAppRest-0.1/webresources/rest/fejl";
        string _fjernMangelURL = "http://  /SkoleAppRest-0.1/webresources/rest/removefejl/";
        #endregion

        #region Variables
        public bool lokaleModalOpen = false;
        public bool lokalerIsRefreshing = false;
        public bool manglerIsRefreshing = false;
        public bool reservationerIsRefreshing = false;

        public ObservableCollection<Lokale> Lokaler { get; set; }
        public ObservableCollection<Mangel> Mangler { get; set; }
        public ObservableCollection<Mangel> LokaleMangler { get; set; }

        public ObservableCollection<Reservation> Reservationer { get; set; }
        


        private Lokale _selectedLokale;
        public Lokale SelectedLokale
        {
            get
            {
                return _selectedLokale;
            }
            set
            {
                _selectedLokale = value;
                OnPropertyChanged(nameof(SelectedLokale));
            }
        }


        // Lav title til lokale modal.
        private string _selectedLokaleTitle;
        public String SelectedLokaleTitle
         {
            get
            {
                return "Lokale " + SelectedLokale.lokale.ToString("0.00", CultureInfo.InvariantCulture);
            }
            set
            {
                _selectedLokaleTitle = "Lokale " + SelectedLokale.lokale.ToString("0.00", CultureInfo.InvariantCulture);
                OnPropertyChanged(nameof(SelectedLokaleTitle));
            }
        }

        private string _formattedLokale;
        public String FormattedLokale
        {
            get
            {
                return SelectedLokale.lokale.ToString("0.00", CultureInfo.InvariantCulture);
            }
            set
            {
                _formattedLokale = SelectedLokale.lokale.ToString("0.00", CultureInfo.InvariantCulture);
                OnPropertyChanged(nameof(FormattedLokale));
            }
        }

        // Liste af mangler der tilhører et valgt ' SelectedLokale.lokale '.
        public void SetLokaleMangler()
        {
            var _mangel = Mangler;
                if (LokaleMangler != null)
                    LokaleMangler.Clear();

                foreach (var _fejl in _mangel)
                {
                    if (_fejl.lokale == SelectedLokale.lokale)
                     LokaleMangler.Add(_fejl);
                }
        }

        public bool LokaleHarMangel(Lokale _lokale)
        {
             var _mangel = Mangler;

                foreach (var _fejl in _mangel)
                {
                    if (_fejl.lokale == _lokale.lokale)
                        return true;
                }

            return false;
        }
        #endregion

        Command _refreshLokalerCommand;
        Command _refreshManglerCommand;
        Command _refreshReservationerCommand;
        public Command RefreshLokalerCommand => _refreshLokalerCommand;
        public Command RefreshManglerCommand => _refreshManglerCommand;
        public Command RefreshReservationerCommand => _refreshReservationerCommand;

       

        public MainViewModel()
        {
            Lokaler = new ObservableCollection<Lokale>();
            Mangler = new ObservableCollection<Mangel>();
            LokaleMangler = new ObservableCollection<Mangel>();
            Reservationer = new ObservableCollection<Reservation>();
      
            _refreshLokalerCommand = new Command(RefreshLokaleList);
            _refreshManglerCommand = new Command(RefreshMangelList);
            _refreshReservationerCommand = new Command(RefreshReservationerList);

            // Get our lists asynchronously as soon as the app starts.


            Task.Run(async () =>
            {

                RefreshingLokaler = true;
                RefreshingReservationer = true;

                GetLokaler();
                GetReservationer();

                RefreshingLokaler = false;
                RefreshingReservationer = false;

                RefreshingMangler = true;
                if (await GetManglerAsync())
                {
                    RefreshingMangler = false;
                }
                

            });

        }

        #region Lokaler
        public void GetLokaler()
        {
            try
            {
                var json = lokalerJSON.lokaler;

                var _lokaler = JsonConvert.DeserializeObject<List<Lokale>>(json);

                // Just so we don't keep appending the same items. :)
                if (Lokaler != null)
                    Lokaler.Clear();

                foreach (var _lokale in _lokaler)
                {
                    if(Mangler != null)
                        _lokale.mangler = LokaleHarMangel(_lokale);
                    Lokaler.Add(_lokale);
                }
            }
       
            catch (Exception ex)
            {
                Debug.WriteLine("Json error! : " + ex);
            }
        }
        private void RefreshLokaleList()
        {
            Task.Run(() =>
            {
                
                RefreshingLokaler = true;
                GetLokaler();
                RefreshingLokaler = false;

            });
        }
        public bool RefreshingLokaler
        {
            get { return lokalerIsRefreshing; }
            set
            {
                lokalerIsRefreshing = value;
                OnPropertyChanged(nameof(lokalerIsRefreshing));
            }
        }
        #endregion

        #region Mangler
        public async Task<bool> GetManglerAsync()
        {
            try
            {
                var client = new HttpClient();
                var jsonMangler = await client.GetStringAsync(_getManglerURL);

                var _mangler = JsonConvert.DeserializeObject<List<Mangel>>(jsonMangler);

                // Just so we don't keep appending the same items. :)
                if (Mangler != null)
                    Mangler.Clear();

                foreach (var _fejl in _mangler)
                {
                    Mangler.Add(_fejl);
                }

                // opdater lokale listen med de nye mangler/fejl.
                GetLokaler();

                return true;

            }

            catch (Exception ex)
            {
                Debug.WriteLine("Json error! : " + ex);
                return false;
            }
        }
        private void RefreshMangelList()
        {
            Task.Run(async () =>
            {
                if (!RefreshingMangler)
                {
                    RefreshingMangler = true;
                    if (await GetManglerAsync())
                        RefreshingMangler = false;
                }
                else
                    return;
            });
           
        }
        public bool RefreshingMangler
        {
            get
            {
                return manglerIsRefreshing;
            }
            set
            {
                manglerIsRefreshing = value;
                OnPropertyChanged(nameof(manglerIsRefreshing));
            }
        }

        public async Task<bool> DeleteMangelAsync(Mangel mangel)
        {
            try
            {
                var client = new HttpClient();
               
                var result = await client.DeleteAsync(_fjernMangelURL + mangel.id);
                
                if(result.IsSuccessStatusCode)
                {
                    Mangler.Remove(mangel);
                    RefreshMangelList();
                    GetLokaler();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Slet error! : " + ex);
                return false;
            }
        }
       

        #endregion

        #region Reservationer
        public void GetReservationer()
        {
            try
            {
                var json = skemaJSON.skema;

                var reservationItems = JsonConvert.DeserializeObject<RootObject>(json);

                // Just so we don't keep appending the same items. :)
                if (Reservationer != null)
                {
                    Reservationer.Clear();
                }

                foreach (var reservationItem in reservationItems.reservations)
                {
                    Reservationer.Add(reservationItem);
                }

            }

            catch (Exception ex)
            {
                Debug.WriteLine("Json error! : " + ex);
            }
        }
        private void RefreshReservationerList()
        {
            Task.Run(() =>
           {
               RefreshingReservationer = true;
               GetReservationer();
               RefreshingReservationer = false;
           });
        }
        public bool RefreshingReservationer
        {
            get { return reservationerIsRefreshing; }
            set
            {
                reservationerIsRefreshing = value;
                OnPropertyChanged(nameof(reservationerIsRefreshing));
            }
        }
        #endregion

        #region Push Notifications

        public bool GetMangelNotifications
        {
            get => Helpers.Settings.GetMangelNotifications;
            set
            {
                if (Helpers.Settings.GetMangelNotifications == value)
                    return;

                Helpers.Settings.GetMangelNotifications = value;
                OneSignal.Current.SetSubscription(value);
                OnPropertyChanged(nameof(GetMangelNotifications));
            }
        }

        #endregion


        #region INotifyPropertyChanged implementation  
        //To let the UI know that something changed on the View Model
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
