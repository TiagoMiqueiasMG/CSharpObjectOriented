using System.Security.Cryptography.X509Certificates;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscriptions{ get; set; }
    
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    
    }
}
