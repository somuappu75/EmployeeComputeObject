using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class ComputeEmpWage
    {
        public string company;
        public int wagePerHour;
        public int maxHoursPerMonth;
        public int maxWorkingDays;
        public int totalWage;
        public int dailyWage = 0;


        public ComputeEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.maxWorkingDays = maxWorkingDays;
        }
        public void setTotalEmpWage(int totalWage, int dailyWage)
        {
            this.totalWage = totalWage;
            this.dailyWage = dailyWage;
        }

        public string toString()
        {
            return "Total Employee Wage for Company  " + this.company + " is " + this.totalWage + "\n";
        }
        public string DailywageCalc()
        {
            return "Daily Employee Wage for Company  " + this.company + " is " + this.dailyWage;
        }
    }
}