//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Android.Support.V4.View;
//using AppCompactApp.Model;

//namespace AppCompactApp.Adapters
//{
//    public class TreePagerAdapter : PagerAdapter
//    {
//        Context context;
//        TreeCatalog treeCatalog;

//        public TreePagerAdapter(Context context, TreeCatalog treeCatalog)
//        {
//            this.context = context;
//            this.treeCatalog = treeCatalog;
//        }

//        public override int Count
//        {
//            get { return treeCatalog.NumTrees; }
//        }

//        public override bool IsViewFromObject(View view, Java.Lang.Object obj)
//        {
//            throw new NotImplementedException();
//        }

//        public override Java.Lang.Object InstantiateItem(View container, int position)
//        {
//            var imageView = new ImageView(context);
//            imageView.SetImageResource(treeCatalog[position].imageId);
//            var viewPager = container.JavaCast<ViewPager>();
//            viewPager.AddView(imageView);
//            return imageView;
//        }

//        public override void DestroyItem(View container, int position, Java.Lang.Object view)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}