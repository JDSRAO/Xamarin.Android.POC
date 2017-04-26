using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ApiConnect
{
    [Activity(Label = "MasterDetailActivity", MainLauncher = true)]
    public class MasterDetailActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MasterDetailLayout);
            ListView lst = FindViewById<ListView>(Resource.Id.lstView);
            var lstItems = new List<String> { "Roy Mustang", "General Armstrong", "Feurer Bradley" };
            //var lstItems1 = new string[] { "Roy Mustang", "General Armstrong", "Feurer Bradley" };
            var lstAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, lstItems);
            lst.Adapter = lstAdapter;
            lst.ItemSelected += Lst_ItemSelected;
            lst.ItemClick += Lst_ItemClick;
            //lst.OnItemSelectedListener = Lst_ItemClick;
        }

        private void Lst_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            ListView lst = (ListView)sender;
            var items = lst.SelectedItemPosition.ToString();
            TextView tv = FindViewById<TextView>(Resource.Id.tv1);
            tv.Text = items;
        }

        private void Lst_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Toast.MakeText(this, (string)sender, ToastLength.Long).Show();
        }
    }
}