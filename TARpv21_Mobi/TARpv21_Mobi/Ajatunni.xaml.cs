using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_Mobi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajatunni : ContentPage
    {

        private List<Task> tasks;
        List<string> taskNames = new List<string> { "Подъем", "Завтрак", "Учеба","Перекус","Учеба2", "Чилл", "Общение", "Вождение","Домой","Играть","Ужин","Сон"};
        List<string> descriptions = new List<string>
        {
            "Проснуться вообще",
            "Приготовить покушатс",
            "Сидеть учиться надо бы",
            "Покушать на обэдэ",
            "Снова на учебу",
            "Захотелось полежать",
            "Общение с людишками",
            "Поехал кататься на машинке",
            "Поехать домой",
            "Играть в компуктер",
            "Вечерний перекус",
            "Время прилечь подремать"

        };

        public class Task
        {
            public System.TimeSpan Time { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
            public string task { get; set; }
        }

        public Ajatunni()
        {
            InitializeComponent();

            tasks = new List<Task>();

            for (int i = 0; i <= 11; i++)
            {
                tasks.Add(new Task
                {
                    Image = $"img{i}.png",
                    task = taskNames[i],
                    Time = new System.TimeSpan(8 + i, 0, 0),
                    Description = descriptions[i]
                });
            }

            myListView.ItemsSource = tasks;
            myListView.ItemTapped += ListViewItem;

        }


        private async void ListViewItem(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var task = (Task)e.Item;
                await DisplayAlert("Описание задачи", task.Description, "OK");
                myListView.SelectedItem = null;
            }
        }

    }
}