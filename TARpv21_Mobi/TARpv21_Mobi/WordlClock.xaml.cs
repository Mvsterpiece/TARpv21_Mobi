using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace TARpv21_Mobi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordlClock : ContentPage
    {
        public WordlClock()
        {
            InitializeComponent();
        }


        private void OnConvertTimeClicked(object sender, EventArgs e)
        {
            string timeZoneId = (string)timeZonePicker.SelectedItem;

            TimeSpan selectedTime = timePicker.Time;

            DateTime selectedDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                                      selectedTime.Hours, selectedTime.Minutes, selectedTime.Seconds);

            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            DateTime convertedDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);

            resultLabel.Text = $"Выбранное время {timeZoneId}: {selectedDateTime.ToString()} \n Конвертированное время: {convertedDateTime.ToString()}";
        }

    }
}