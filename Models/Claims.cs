using System;

namespace FisherInsuranceApi.Claims{
    public class Claim
    
    {
        public int Id { get; set; }
         public string PolicyNumber { get; set; }
         public DateTime LossDate { get; set; }

          public decimal LossAmount { get; set; }

          public string Status { get; set; }
    }

}