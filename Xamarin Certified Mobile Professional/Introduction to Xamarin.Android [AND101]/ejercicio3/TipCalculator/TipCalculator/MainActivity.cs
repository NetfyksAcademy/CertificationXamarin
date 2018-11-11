using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace TipCalculator
{
	[Activity(Label = "@string/app_name", MainLauncher = true)]
	public class MainActivity : Activity
    {
        EditText inputBill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;

        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += OnCalculateClick;

        }

        private void OnCalculateClick(object sender, EventArgs e)
        {
            string text = inputBill.Text;
            var bill = double.Parse(text);

            var tip = bill * 0.15;
            var total = bill + tip;

            outputTip.Text = tip.ToString();
            outputTotal.Text = total.ToString();

        }
    }
}

