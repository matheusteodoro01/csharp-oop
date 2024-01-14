using Balta.NotificationContext;

namespace Balta.SharedContext
{
  public abstract class Base : Notifiable
  {
    public Base()
    {
      Id = Guid.NewGuid(); //SPOF Unico ponto de falha em todas as outras classes
    }

    public Guid Id { get; set; }
  }
}