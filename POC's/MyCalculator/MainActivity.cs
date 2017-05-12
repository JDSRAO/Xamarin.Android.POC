using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyCalculator
{
    [Activity(Label = "MyCalculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button button0;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Button button7;
        Button button8;
        Button button9;
        Button Add;
        Button Minus;
        Button Multiply;
        Button Divide;
        Button Compute;
        Button Decimal;
        Button Delete;
        Button Clear;
        TextView Result;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button0 = FindViewById<Button>(Resource.Id.button0);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button3 = FindViewById<Button>(Resource.Id.button3);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button5 = FindViewById<Button>(Resource.Id.button5);
            button6 = FindViewById<Button>(Resource.Id.button6);
            button7 = FindViewById<Button>(Resource.Id.button7);
            button8 = FindViewById<Button>(Resource.Id.button8);
            button9 = FindViewById<Button>(Resource.Id.button9);
            Add = FindViewById<Button>(Resource.Id.buttonPlus);
            Minus = FindViewById<Button>(Resource.Id.buttonMinus);
            Multiply = FindViewById<Button>(Resource.Id.button1Multiply);
            Divide = FindViewById<Button>(Resource.Id.buttonDivide);
            Compute = FindViewById<Button>(Resource.Id.buttonShowAnswer);
            Decimal = FindViewById<Button>(Resource.Id.buttonDecimal);
            Delete = FindViewById<Button>(Resource.Id.buttonDelete);
            Clear = FindViewById<Button>(Resource.Id.buttonClear);

            Result = FindViewById<TextView>(Resource.Id.resultScreen);

            button0.Click += delegate { Result.Text += string.Format("{0}", button0.Text); };
            button1.Click += delegate { Result.Text += string.Format("{0}", button1.Text); };
            button2.Click += delegate { Result.Text += string.Format("{0}", button2.Text); };
            button3.Click += delegate { Result.Text += string.Format("{0}", button3.Text); };
            button4.Click += delegate { Result.Text += string.Format("{0}", button4.Text); };
            button5.Click += delegate { Result.Text += string.Format("{0}", button5.Text); };
            button6.Click += delegate { Result.Text += string.Format("{0}", button6.Text); };
            button7.Click += delegate { Result.Text += string.Format("{0}", button7.Text); };
            button8.Click += delegate { Result.Text += string.Format("{0}", button8.Text); };
            button9.Click += delegate { Result.Text += string.Format("{0}", button9.Text); };
            Decimal.Click += delegate { Result.Text += string.Format("{0}", Decimal.Text); };

            Add.Click += delegate { Result.Text += string.Format("{0}", Add.Text); };
            Minus.Click += delegate { Result.Text += string.Format("{0}", Minus.Text); };
            Multiply.Click += delegate { Result.Text += string.Format("{0}", Multiply.Text); };
            Divide.Click += delegate { Result.Text += string.Format("{0}", Divide.Text); };

            Delete.Click += delegate { this.DeleteNumber(); };
            Compute.Click += delegate { this.ComputeResult(); };
            Clear.Click += delegate { this.ClearNumber(); };

        }

        public void ClearNumber()
        {
            Result.Text = "0";
        }
        public void DeleteNumber()
        {
            string original = Result.Text;
            int originalLength = original.Length;
            string deleted = original.Remove(originalLength - 1, 1);
            this.Result.Text = deleted;
        }
        public void ComputeResult()
        {
            AddNumbers();
        }
        public void AddNumbers()
        {
            string[] numbers = GetNumbers();
            int num1 = Convert.ToInt32(numbers[0]);
            int num2 = Convert.ToInt32(numbers[1]);
            Result.Text = Convert.ToString(num1 + num2);
        }
        public string[] GetNumbers()
        {
            string operandText = Result.Text;
            string[] operands = operandText.Split('+');
            return operands;
        }
    }
}

