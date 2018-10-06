using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// name and student number: Shubham Hirpara, 000770045
///file date: 21st september, 2018
///The program's purpose: read data from file and manipulate it.
///Statement of Authorship: I, Shubham Hirpara, student number 000770045, certify that all code submitted is my own work; that I have not copied it from any other source.
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace LAB1_DOTNET
{
    class Employee
    {
        /// <summary>
        /// Class variables 
        /// name : to save employee name
        /// </summary>
        private string name;
        /// <summary>
        /// number : to save employee number
        /// </summary>
        private int number;
        /// <summary>
        /// rate : to save rate of employee
        /// </summary>
        private decimal rate;
        /// <summary>
        /// hours : to save number of hours employee worked
        /// </summary>
        private double hours;
        /// <summary>
        /// gross : to save gross of employee and initialized by 0
        /// </summary>
        private decimal gross = 0;

        /// <summary>
        /// Employee class constructor
        /// </summary>
        /// <param name="name">to save employee name</param>
        /// <param name="number">to save employee number</param>
        /// <param name="rate">to save rate of employee</param>
        /// <param name="hours">to save number of hours employee worked</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }
        /// <summary>
        /// to get name of the employee
        /// </summary>
        /// <returns>name of employee</returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// to get number of the employee
        /// </summary>
        /// <returns>employee number</returns>
        public int GetNumber()
        {
            return number;
        }
        /// <summary>
        /// to get rate of the employee
        /// </summary>
        /// <returns>rate of employee</returns>
        public decimal GetRate()
        {
            return rate;
        }
        public double GetHours()
        {
            return hours;
        }
        /// <summary>
        /// GetGross method is to retrive(read) the calculated value of gross.
        /// Condition: if hours if less or equal to 40 then reguler rate will apply.
        /// but the hours over 40 hours will be calculated as overtime and one&half rate will apply to calculate.
        /// </summary>
        /// <returns>calculated gross</returns>
        public decimal GetGross()
        {

            if ((hours <= 40))
            {
                gross = rate * (decimal)hours;            }
            else
            {
                /// <summary>
                /// overHours : to save hours which is more then 40 
                /// </summary>
                Double overHours = hours - 40;
                gross = (rate * (decimal)(1.5 * overHours)) + (rate * (decimal)hours);
            }
            return gross;
        }
        /// <summary>
        /// ToString method 
        /// </summary>
        /// <returns>returns variables names and its values ( name, number, rate, hours )</returns>
        public override string ToString()
        {
            return $"Name = {name} , Number = {number} , Rate = {rate} , Hours = {hours}";
        }
        /// <summary>
        /// to set hours after object has benn created.
        /// </summary>
        /// <param name="hours">hours that employee has worked</param>
        public void SetHours(double hours)
        {
            this.hours = hours;
        }
        /// <summary>
        /// to set name after object has benn created.
        /// </summary>
        /// <param name="name">name of the employee</param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// to set number of employee after object has benn created.
        /// </summary>
        /// <param name="employee">employee number</param>
        public void SetNumber(int number)
        {
            this.number = number;
        }
        /// <summary>
        /// to set rate of employee after object has benn created.
        /// </summary>
        /// <param name="rate">rate of employee</param>
        public void SetRate(decimal rate)
        {
            this.rate = rate;
        }


    }
}
