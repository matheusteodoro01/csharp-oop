using Balta.SharedContext;

namespace Balta.ContentContext;


public class Module : Base
{
  public Module()
  {
    Lectures = new List<Lecture>();
  }

  public Module(int order, string title, IList<Lecture> lectures)
  {
    Order = order;
    Title = title;
    Lectures = lectures;
  }

  public int Order { get; set; }
  public string Title { get; set; }
  public IList<Lecture> Lectures { get; set; }

}