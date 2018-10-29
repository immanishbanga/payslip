using System.ComponentModel.DataAnnotations;

namespace Common
{
    /// <summary>
    /// Represents payslip generated for specific employee
    /// </summary>
    public class Payslip
    {
        /// <summary>
        /// Gets or sets employee's full name 
        /// </summary>
        [Display(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets pay period
        /// </summary>
        [Display(Name = "Pay Period")]
        public string PayPeriod { get; set; }

        /// <summary>
        /// Gets or sets grodd income
        /// </summary>
        [Display(Name = "Gross Income")]
        public int GrossIncome { get; set; }

        /// <summary>
        /// Gets or sets income tax
        /// </summary>
        [Display(Name = "Income Tax")]
        public int IncomeTax { get; set; }
        
        /// <summary>
        /// Gets or sets net income
        /// </summary>
        [Display(Name = "Net Income")]
        public int NetIncome { get; set; }

        /// <summary>
        /// Gets or sets super amount
        /// </summary>
        [Display(Name = "Super Amount")]
        public int SuperAmount { get; set; }
    }
}