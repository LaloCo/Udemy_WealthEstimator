using System;
using WealthCalculator;
using UIKit;

namespace Wealth_Estimator.iOS
{
    public partial class ViewController : UIViewController
    {
        Wealth wealthCalculator;
        public ViewController(IntPtr handle)
            : base(handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            wealthCalculator = new Wealth();

            calculateButton.TouchUpInside += CalculateButton_TouchUpInside;
        }

        void CalculateButton_TouchUpInside (object sender, EventArgs e)
        {
            if (interestTextField.Text != "" && yearsTextField.Text != "" && investmentTextField.Text != "" && compoundingTextField.Text != "")
            {
                float interest = float.Parse(interestTextField.Text);
                int years = int.Parse(yearsTextField.Text);
                float monthlyInvestment = float.Parse(investmentTextField.Text);
                int compounds = int.Parse(compoundingTextField.Text);

                wealthCalculator.calculateWealth(monthlyInvestment, compounds, interest, years);

                moneyLabel.Text = string.Format("{0:C}", wealthCalculator.CumulativeWealth);
                investmentLabel.Text = string.Format("{0:C}", wealthCalculator.CumulativeInvestment);
                interestLabel.Text = string.Format("{0:C}", wealthCalculator.CumulativeInterest);

                summaryLabel.Text = string.Format("With an monthly investment of {0:C} for {1} years compounded {2} times a year at an annual interest rate of {3:P}, your money would grow to", monthlyInvestment, years, compounds, interest / 100);
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

