using InsuranceAPI.Model;
using InsuranceAPI.Delegate;

namespace InsuranceAPI.Manager;

public class PolicyManager
{
    public List<Policy> policies = new List<Policy>();

    public event PolicyDelegate PolicyPurchased;


    public void AddPolicy(Policy policy)
    {
        policies.Add(policy);
        PolicyPurchased?.Invoke($"Policy for{policy.CustomerName} has been purchased.");

    } 
    
    public List<Policy> GetPolicies()
    {
        return policies;
    }

}
