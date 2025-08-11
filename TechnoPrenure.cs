using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class TechnoPrenure : PersonDetails, IEntrepreneur
    {

        public TechnoPrenure()
        {
            BusinessName = "Unknown";
            BusinessType = "Unknown";
            Location = "Unknown";
            InvestmentAmount = 0.0;
            YearsInBusiness = 0;
        }

        public TechnoPrenure(string name, int age, string address, string phoneNumber, string email, string occupation,
                        int entrepreneurId, string businessName, string businessType, string location,
                        double investmentAmount, int yearsInBusiness)
            : base(name, age, address, phoneNumber, email, occupation)
        {
            EntrepreneurId = entrepreneurId;
            BusinessName = businessName;
            BusinessType = businessType;
            Location = location;
            InvestmentAmount = investmentAmount;
            YearsInBusiness = yearsInBusiness;
        }
        public int EntrepreneurId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public string Location { get; set; }
        public double InvestmentAmount { get; set; }
        public int YearsInBusiness { get; set; }
        public void DisplayEntroprenurDetails()
        {
            Console.WriteLine($"Entrepreneur ID: {EntrepreneurId}");
            Console.WriteLine($"Business Name: {BusinessName}");
            Console.WriteLine($"Business Type: {BusinessType}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Investment Amount: {InvestmentAmount}");
            Console.WriteLine($"Years in Business: {YearsInBusiness}");
            base.DisplayPersonDetails(); // Call the base class method to display person details
        }
        public string GetEntroprenurInfo()
        {
            return $"Entrepreneur ID: {EntrepreneurId}, Business Name: {BusinessName}, Business Type: {BusinessType}, Location: {Location}, " +
                   $"Investment Amount: {InvestmentAmount}, Years in Business: {YearsInBusiness}, " +
                   base.GetPersonDetails(); // Call the base class method to get person info
        }
    }
}

