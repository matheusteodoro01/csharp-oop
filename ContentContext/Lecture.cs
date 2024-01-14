using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{

  public class Lecture : Base
  {
    public Lecture(int ordem, string title, int durationInMinutes, EContentLevel level)
    {
      Ordem = ordem;
      Title = title;
      DurationInMinutes = durationInMinutes;
      Level = level;
    }

    public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}

