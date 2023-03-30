using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using static TARpv21_Mobi.Ajatunni;

namespace TARpv21_Mobi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordlClock : ContentPage
    {
        public WordlClock()
        {
            InitializeComponent();
        }



        private async void OnCalculateTimeDifferenceClicked(object sender, EventArgs e)
        {
            string timeZoneId = (string)timeZonePicker.SelectedItem;

            try
            {
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                DateTime currentTimeInSelectedTimeZone = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);

                TimeSpan timeDifference = currentTimeInSelectedTimeZone - DateTime.Now;

                timeDifferenceLabel.Text = timeDifference.ToString();
                resultLabel.Text = $"Текущее время {timeZoneId}: {currentTimeInSelectedTimeZone.ToString()}";
            }
            catch
            {
                await DisplayAlert("Ошибка", "Выберите регион", "OK");
            }

        }

    }
}