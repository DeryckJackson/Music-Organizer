using System.Collections.Generic;

namespace MusicOrganizer
{
  public class Record
  {
    public string Title { get; set; }
    public int Id { get; }
    private List<Record> _instances = new List<Record>();

    public Record(string title)
    {
      Title = title;
      _instances.Add(this);
      Id = _instances.Count - 1;
    }

    public static void ClearAll()
    {
      _instances.Clear():
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }

    public static Record Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}