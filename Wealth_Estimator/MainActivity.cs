using Android.App;
using Android.Widget;
using Android.OS;

namespace Wealth_Estimator
{
    [Activity(Label = "Wealth_Estimator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        WealthCalculator.Wealth wealthCalculator;
        TextView summaryTextView, cumulativeWealthTextView, cumulativeInvestmentTextView, cumulativeInterestTextView;
        EditText monthlyInvestmentEditText, compoundsEditText, interestEditText, yearsEditText;
        Button calculateButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            wealthCalculator = new WealthCalculator.Wealth();

            summaryTextView = FindViewById<TextView>(Resource.Id.summaryTextView);
            cumulativeWealthTextView = FindViewById<TextView>(Resource.Id.moneyTextView);
            cumulativeInvestmentTextView = FindViewById<TextView>(Resource.Id.investmentTextView);
            cumulativeInterestTextView = FindViewById<TextView>(Resource.Id.interestTextView);

            monthlyInvestmentEditText = FindViewById<EditText>(Resource.Id.investmentEditText);
            compoundsEditText = FindViewById<EditText>(Resource.Id.compoundingEditText);
            interestEditText = FindViewById<EditText>(Resource.Id.interestEditText);
            yearsEditText = FindViewById<EditText>(Resource.Id.yearsEditText);

            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            calculateButton.Click += CalculateButton_Click;
        }

        void CalculateButton_Click (object sender, System.EventArgs e)
        {
            if (monthlyInvestmentEditText.Text != "" && compoundsEditText.Text != "" && interestEditText.Text != "" && yearsEditText.Text != "")
            {
                float monthlyInvestment = float.Parse(monthlyInvestmentEditText.Text);
                int compounds = int.Parse(compoundsEditText.Text);
                float interest = float.Parse(interestEditText.Text);
                int years = int.Parse(yearsEditText.Text);

                wealthCalculator.calculateWealth(monthlyInvestment, compounds, interest, years);

                cumulativeWealthTextView.Text = string.Format("{0:C}", wealthCalculator.CumulativeWealth);
                cumulativeInvestmentTextView.Text = string.Format("{0:C}", wealthCalculator.CumulativeInvestment);
                cumulativeInterestTextView.Text = string.Format("{0:C}", wealthCalculator.CumulativeInterest);

                summaryTextView.Text = string.Format("With an monthly investment of {0:C} for {1} years compounded {2} times a year at an annual interest rate of {3:P}, your money would grow to", monthlyInvestment, years, compounds, interest / 100);
            }
        }
    }
}


