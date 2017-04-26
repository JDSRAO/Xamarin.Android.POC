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
using Java.IO;

namespace Reminder.Code
{
     public class Reminder /*: ISerializable*/
    {
        public string Description { get; set; }
        public DateTime Time { get; set; }

        public DateTime Date { get; set; }

        //public IntPtr Handle
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        
        
        public bool Save()
        {
            



            return true;
        }

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}