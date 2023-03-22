using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Mobi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_Page : ContentPage
    {
        List<ContentPage> contentPages = new List<ContentPage>() { new Horoskoop_Page(), new Ajatunni() };
        List<string> tekstid = new List<string> { "Horoskoop", "Ajatunniplaan" };
        public Start_Page()
        {

            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Gray
            };
            for (int i = 0; i < contentPages.Count; i++)
            {
                Button button = new Button
                {
                    Text = tekstid[i],
                    TabIndex = i,
                    BackgroundColor = Color.AliceBlue,
                    TextColor = Color.Black
                };
                button.Clicked += Navig_funktsion;
                st.Children.Add(button);
            }
            Content = st;
        }
        private async void Navig_funktsion(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            await Navigation.PushAsync(contentPages[b.TabIndex]);
        }
    }

}