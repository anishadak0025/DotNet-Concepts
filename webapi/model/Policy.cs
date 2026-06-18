using System.Dynamic;

namespace InsuranceAPI.Model;

public class Policy
{
    public int Id {get; set;}
    public string CustomerName {get; set;}

    public string PolicyType {get; set;}

    public double Premium {get; set;}
    


}