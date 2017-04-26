using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiConnect
{
    [Activity(Label = "ApiConnect", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async (sender,r) =>
            {
                bool result = await test();
                button.Text = string.Format("{0} clicks!", count++);
            };

        }

        private async Task<bool> test()
        {
           bool res = await RefreshDataAsync();
            if (res)
            {
                return true;
            }
            return false;
        }

        public async System.Threading.Tasks.Task<bool> RefreshDataAsync()
        {

            //string RestUrl = "http://developer.xamarin.com:8081/api/todoitems{0}";
            string RestUrl = "http://maps.googleapis.com/maps/api/geocode/json?address=india&sensor=true_or_false";
            var uri = new Uri(string.Format(RestUrl, string.Empty));

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
                return true;
            }
            return false;
            //string loginURl = "http://maps.googleapis.com/maps/api/geocode/json?address=india&sensor=true_or_false";
            //try
            //{
            //    HttpClient client = new HttpClient();
            //    var response = client.GetStringAsync(loginURl);
            //    var json = await response;
            //    //var jsonObject = JsonConvert.DeserializeObject<Response>(json);
            //    //books = jsonObject.Books;

            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}

        }
    }
}

