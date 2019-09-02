using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DesplayAlert_vs19
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); //inisial ini tidak diambil dari kode xaml nya, 
                                   //melainkan diambil dari MainPage.xaml.g.cs yang ada di obj->Debug->netstandard2.0
                                   // private void InitializeComponent() {
                                   //   global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
                                   // }
        Content = new Label // dan ini adalah cara untuk menuliskan tampilan secara dinamis melalui kode.cs tetapi ini terlalu panjang dan tidak direkomendasikan
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hello World"
            };
            
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Don't skip the information","Ok");
        }
    }
}
