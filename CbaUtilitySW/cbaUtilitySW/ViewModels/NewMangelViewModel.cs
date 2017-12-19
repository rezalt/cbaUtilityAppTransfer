using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cbaUtility.ViewModels
{
    class NewMangelViewModel
    {

        string _nyMangelURL = "http://  /SkoleAppRest-0.1/webresources/rest/addfejl";

        MainViewModel mvm;

        public NewMangelViewModel()
        {
            mvm = ViewModelLocator.MainViewModel;
        }

        public async Task<bool> NewMangelAsync(
            string _lokale,
            string _beskrivelse,
            string _prio,
            bool _manglerLys,
            bool _manglerProjekter,
            bool _manglerBorde,
            bool _manglerStole
        )
        {

            Mangel mangel;
            mangel = new Mangel
            {
                lokale = decimal.Parse(_lokale, CultureInfo.InvariantCulture),
                prio = "Lav",
                dato = "",
                beskrivelse = _beskrivelse,
                manglerLys = _manglerLys,
                manglerProjekter = _manglerProjekter,
                manglerBorde = _manglerBorde,
                manglerStole = _manglerStole
            };


            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(mangel), Encoding.UTF8, "application/json");
            var result = new HttpResponseMessage();
            try
            {
                result = await client.PostAsync(_nyMangelURL, content);
                if (result.IsSuccessStatusCode)
                {
                    await mvm.GetManglerAsync();
                    mvm.GetLokaler();
                    mvm.SetLokaleMangler();
                    return true;
                }
                else
                    return false;
              
            }
            catch (Exception ex)
            {
                if (result == null)
                {
                    result = new HttpResponseMessage();
                }
                result.StatusCode = HttpStatusCode.InternalServerError;
                result.ReasonPhrase = string.Format("RestHttpClient.SendRequest failed: {0}", ex);
                return false;
            }

        }
    }
}
