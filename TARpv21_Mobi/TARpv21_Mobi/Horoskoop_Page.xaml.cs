using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TARpv21_Mobi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horoskoop_Page : ContentPage
    {

        public Horoskoop_Page()
        {
            DatePicker data = new DatePicker();
            data.DateSelected += Data_DateSelected;
            Image img = new Image
            {
                Source = "horoskoop.jpg",
                WidthRequest= 150,
                HeightRequest= 150,
            };

            StackLayout st = new StackLayout { Orientation = StackOrientation.Vertical, BackgroundColor = Color.Gray, Children= { img, data } };
            Content = st;



        }

        private void Data_DateSelected(object sender, DateChangedEventArgs e)
        {
            Dictionary<string, string> horoscopeData = new Dictionary<string, string>()
            {
                {"Овен", "Ваша независимая природа сегодня может быть поставлена под сомнение. Оставайтесь открытыми для других перспектив."},
                {"Телец", "Ваша тяжелая работа окупается. Найдите минутку, чтобы оценить свои достижения."},
                {"Близнецы", "Ваши коммуникативные навыки будут подвергнуты испытанию. Будьте ясны и прямолинейны."},
                {"Рак", "Ваша чувствительность сегодня может быть повышенной. Позаботьтесь о своем эмоциональном благополучии."},
                {"Лев", "Сегодня нужны ваши лидерские качества. Берите на себя ответственность и принимайте смелые решения."},
                {"Дева", "Сегодня важно ваше внимание к деталям. Сосредоточьтесь на мелочах."},
                {"Весы", "Сегодня ваше чувство равновесия может быть нарушено. Стремитесь к гармонии во всех сферах жизни."},
                {"Скорпион", "Ваша интуиция сегодня может быть сильна. Доверьтесь своим инстинктам."},
                {"Стрелец", "Возможно, сегодня у вас обострится тяга к приключениям. Рискните и исследуйте что-то новое."},
                {"Козерог", "Сегодня важна ваша практичность. Сосредоточьтесь на своих целях и сохраняйте дисциплину."},
                {"Водолей", "Ваши нестандартные идеи могут быть оценены сегодня. Примите свою уникальность."},
                {"Рыбы", "Ваш творческий потенциал может проснуться сегодня. Дайте волю своему воображению."}
            };


            string horoscopeSign = "";
            if (e.NewDate.Month == 3 && e.NewDate.Day >= 21 || e.NewDate.Month == 4 && e.NewDate.Day <= 19)
            {
                horoscopeSign = "Овен";
            }
            else if (e.NewDate.Month == 4 && e.NewDate.Day >= 20 || e.NewDate.Month == 5 && e.NewDate.Day <= 20)
            {
                horoscopeSign = "Телец";
            }
            else if (e.NewDate.Month == 5 && e.NewDate.Day >= 21 || e.NewDate.Month == 6 && e.NewDate.Day <= 20)
            {
                horoscopeSign = "Близнецы";
            }





        }
    }
}