using System.Collections.Generic;
using InsuranceApp.Contracts.ResponseObjects;

namespace InsuranceApp.Areas.Broker.ViewModels
{
    public class CalculatePolicyViewModel
    {
        public CoverResponse Cover { get; set; }
        public List<LimitResponse> Limits { get; set; }
        
    }
}