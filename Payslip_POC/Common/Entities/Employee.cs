using System;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    /// <summary>
    /// Represents employee object
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets employee first name
        /// </summary>
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets employee's last name
        /// </summary>
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name.")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets employee's annnual salary
        /// </summary>
        [Display(Name = "Annual Salary")]
        [Required(ErrorMessage = "Please enter annual salary.")]
        public Int64 AnnualSalary { get; set; }

        /// <summary>
        /// Gets or sets super rate
        /// </summary>
        [Display(Name = "Super Rate")]
        [Required(ErrorMessage = "Please enter super rate.")]
        [Range(0, 12, ErrorMessage = "Please enter super rate from 0 to 12.")]
        public double SuperRate { get; set; }

        /// <summary>
        /// Gets or sets payment start date
        /// </summary>
        [Display(Name = "Payment Start Date (mm/dd/yyyy)")]
        [Required(ErrorMessage = "Please enter payment start date.")]
        [DataType(DataType.Date, ErrorMessage = "Please enter date in correct format.")]
        public DateTime PaymentStartDate { get; set; }
    }
}