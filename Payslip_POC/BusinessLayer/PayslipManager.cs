using Common;
using System;

namespace BusinessLayer
{
    public class PayslipManager
    {
        /// <summary>
        /// Generates payslip for specified employee's details
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Payslip GeneratePaySlip(Employee model)
        {
            Payslip objPayslip = new Payslip();
            objPayslip.Name = model.FirstName + ' ' + model.LastName;
            objPayslip.PayPeriod = new DateTime(model.PaymentStartDate.Year, model.PaymentStartDate.Month, 1).ToShortDateString() + " to " + new DateTime(model.PaymentStartDate.Year, model.PaymentStartDate.Month, DateTime.DaysInMonth(model.PaymentStartDate.Year, model.PaymentStartDate.Month)).ToShortDateString();
            objPayslip.GrossIncome = Convert.ToInt32(model.AnnualSalary / 12);
            if (model.AnnualSalary >= 0 && model.AnnualSalary <= 18200)
            {
                objPayslip.IncomeTax = 0;
            }
            if (model.AnnualSalary > 18200 && model.AnnualSalary <= 37000)
            {
                objPayslip.IncomeTax = Convert.ToInt32(((model.AnnualSalary - 18200) * 19 / 100) / 12);
            }
            if (model.AnnualSalary > 37000 && model.AnnualSalary <= 87000)
            {
                objPayslip.IncomeTax = Convert.ToInt32((3572 + ((model.AnnualSalary - 37000) * 32.5 / 100)) / 12);
            }
            if (model.AnnualSalary > 87000 && model.AnnualSalary <= 180000)
            {
                objPayslip.IncomeTax = Convert.ToInt32((19822 + ((model.AnnualSalary - 87000) * 37 / 100)) / 12);
            }
            if (model.AnnualSalary > 180000)
            {
                objPayslip.IncomeTax = Convert.ToInt32((54232 + ((model.AnnualSalary - 180000) * 45 / 100)) / 12);
            }
            objPayslip.NetIncome = Convert.ToInt32(objPayslip.GrossIncome - objPayslip.IncomeTax);
            objPayslip.SuperAmount = Convert.ToInt32(objPayslip.GrossIncome * model.SuperRate / 100);
            return objPayslip;
        }
    }
}
