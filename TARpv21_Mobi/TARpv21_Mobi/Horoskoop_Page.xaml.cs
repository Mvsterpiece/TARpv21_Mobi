using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Mobi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horoskoop_Page : ContentPage
    {
        public Horoskoop_Page()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime selectedDate = e.NewDate;
            string horoscopeText = GetHoroscopeText(selectedDate);
            editor.Text = horoscopeText;
            string horoscopeImage = GetHoroscopeImage(selectedDate);
            image.Source = horoscopeImage;
        }

        private string GetHoroscopeImage(DateTime selectedDate)
        {
            string[] zodiacImage = new string[]
            {
                 "Козерог",
                 "Водолей",
                 "Рыбы",
                 "Овен",
                 "Телец",
                 "Близнецы",
                 "Рак",
                 "Лео",
                 "Дева",
                 "Весы",
                 "Скорпион",
                 "Стрелец"
            };
            int[] zodiacSignStartDays = new int[]
            {
                20, 19, 21, 20, 21, 21, 22, 23, 23, 23, 22, 22
            };
            int month = selectedDate.Month;
            int day = selectedDate.Day;
            int zodiacIndex = month - 1;
            if (day < zodiacSignStartDays[zodiacIndex])
            {
                zodiacIndex--;
                if (zodiacIndex < 0)
                {
                    zodiacIndex = 11;
                }
            }
            string zodiacSign = zodiacImage[zodiacIndex];

            Dictionary<string, string> horoImages = new Dictionary<string, string>()
            {
                { "Водолей", "voda.png" },
                { "Рыбы", "fish.png" },
                { "Овен", "oven.png" },
                { "Телец", "telec.png" },
                { "Близнецы", "twins.png" },
                { "Рак", "rakal.png" },
                { "Лев", "leva.png" },
                { "Дева", "deva.png" },
                { "Весы", "ves.png" },
                { "Скорпион", "skorp.png" },
                { "Стрелец", "strel.png" },
                { "Козерог", "kozer.png" }
            };
            string Images = horoImages[zodiacSign];


            return Images;


        }

        private string GetHoroscopeText(DateTime selectedDate)
        {

            string[] zodiacSigns = new string[]
            {
                 "Козерог",
                 "Водолей",
                 "Рыбы",
                 "Овен",
                 "Телец",
                 "Близнецы",
                 "Рак",
                 "Лео",
                 "Дева",
                 "Весы",
                 "Скорпион",
                 "Стрелец"
            };
            int[] zodiacSignStartDays = new int[]
            {
                20, 19, 21, 20, 21, 21, 22, 23, 23, 23, 22, 22
            };
            int month = selectedDate.Month;
            int day = selectedDate.Day;
            int zodiacIndex = month - 1;
            if (day < zodiacSignStartDays[zodiacIndex])
            {
                zodiacIndex--;
                if (zodiacIndex < 0)
                {
                    zodiacIndex = 11;
                }
            }
            string zodiacSign = zodiacSigns[zodiacIndex];


            Dictionary<string, string> horoscopes = new Dictionary<string, string>()
            {
                 { "Водолей", "Водолей. \nСегодня вы можете столкнуться с неожиданными проблемами. Сосредоточьтесь и сохраняйте позитивный настрой" },
                 { "Рыбы", "Рыбы \nСегодня у вас будет много энергии и энтузиазма. Используйте это в своих интересах для решения сложных задач." },
                 { "Овен", "Овен \nСегодня хороший день, чтобы рискнуть и попробовать что-то новое. Результат может вас приятно удивить." },
                 { "Телец", "Телец \nБудьте осторожны в принятии решений сегодня. Потратьте время на то, чтобы все обдумать, прежде чем действовать" },
                 { "Близнецы", "Близнецы \nСегодня у вас могут возникнуть проблемы со связью. Будьте терпеливы и постарайтесь прояснить любые недоразумения" },
                 { "Рак", "Рак \nВаша тяжелая работа и самоотверженность окупятся сегодня. Продолжайте в том же духе!" },
                 { "Лев", "Лев \nСегодня важно прислушиваться к своей интуиции. Доверяйте своей интуиции и следуйте своим инстинктам" },
                 { "Дева", "Дева \nСегодня вы можете столкнуться с неожиданными препятствиями. Сохраняйте спокойствие и сосредоточьтесь на поиске решений" },
                 { "Весы", "Весы \nУделите сегодня немного времени уходу за собой. Расслабьтесь и зарядитесь энергией, чтобы подготовиться к предстоящей неделе" },
                 { "Скорпион", "Скорпион \nСегодня вы можете получить приятные новости или неожиданные сюрпризы. Наслаждайтесь моментом!" },
                 { "Стрелец", "Стрелец \nЭто хороший день, чтобы сосредоточиться на своих отношениях с другими людьми. Обратитесь к тому, с кем вы давно не разговаривали"},
                 { "Козерог", "Козерог \nСегодня вы можете чувствовать беспокойство. Используйте эту энергию для изучения новых идей и возможностей" }
            };
            string horoscopeText = horoscopes[zodiacSign];


            return horoscopeText;
        }
    }
}