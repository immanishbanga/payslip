using BusinessLayer;
using Common;
using System;
using Xunit;

namespace Payslip.Test
{
    public class PayslipManagerTests
    {
        [Fact]
        public void GeneratePayslip_CheckGrossIncome()
        {
            PayslipManager objManager = new PayslipManager();
            Employee objEmploye = new Employee() { FirstName = "Andrew", LastName = "Smith", AnnualSalary = 60050, SuperRate = 9, PaymentStartDate = new DateTime(2018, 03, 1) };
            Common.Payslip result = objManager.GeneratePaySlip(objEmploye);
            int annualSalary = result.GrossIncome / 12;
            Assert.Equal(annualSalary, result.GrossIncome);
        }

        [Fact]
        public void GeneratePayslip_CheckIncomeTax()
        {
            PayslipManager objManager = new PayslipManager();
            Employee objEmploye = new Employee() { FirstName = "Andrew", LastName = "Smith", AnnualSalary = 60050, SuperRate = 9, PaymentStartDate = new DateTime(2018, 03, 1) };
            Common.Payslip result = objManager.GeneratePaySlip(objEmploye);
            Assert.Equal(922, result.IncomeTax);
        }

        [Fact]
        public void GeneratePayslip_CheckNetIncome()
        {
            PayslipManager objManager = new PayslipManager();
            Employee objEmploye = new Employee() { FirstName = "Andrew", LastName = "Smith", AnnualSalary = 60050, SuperRate = 9, PaymentStartDate = new DateTime(2018, 03, 1) };
            Common.Payslip result = objManager.GeneratePaySlip(objEmploye);
            Assert.Equal(4082, result.NetIncome);
        }

        [Fact]
        public void GeneratePayslip_CheckSuperAmount()
        {
            PayslipManager objManager = new PayslipManager();
            Employee objEmploye = new Employee() { FirstName = "Andrew", LastName = "Smith", AnnualSalary = 60050, SuperRate = 9, PaymentStartDate = new DateTime(2018, 03, 1) };
            Common.Payslip result = objManager.GeneratePaySlip(objEmploye);
            Assert.Equal(450, result.SuperAmount);
        }
    }
}
