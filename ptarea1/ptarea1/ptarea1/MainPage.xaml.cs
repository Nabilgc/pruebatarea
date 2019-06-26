using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;


namespace ptarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GetProduct();

        }

        private async void GetProduct()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://productsdemoapp.azurewebsites.net/api/Products");

            var products = JsonConvert.DeserializeObject<List<Products>>(response);

            ProductsListView.ItemsSource = products;
           
        }
    }
}
