namespace Balta.SubscriptionContext
{

  public class PagarMeSubscription
  {

    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive => EndDate <= DateTime.Now;
  }
}