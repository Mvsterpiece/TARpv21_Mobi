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




        }
    }
}