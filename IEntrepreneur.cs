using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal interface IEntrepreneur
    {
        int EntrepreneurId { get; set; }
        string BusinessName { get; set; }
        string BusinessType { get; set; }
        string Location { get; set; }

        double InvestmentAmount { get; set; }
        int YearsInBusiness { get; set; }

        void DisplayEntroprenurDetails();
        string GetEntroprenurInfo();
    }
}
