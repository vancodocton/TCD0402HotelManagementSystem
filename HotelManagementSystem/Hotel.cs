using System.Collections.Generic;

namespace HotelManagementSystem
{
  public class Hotel
  {
    private string _name;
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public List<HotelLocation> HotelLocations = new List<HotelLocation>();
    public Hotel(string name)
    {
      _name = name;
    }

    public bool AddLocation(string name, string location)
    {
      try
      {
        HotelLocations.Add(new HotelLocation(name, location));
      }
      catch (System.Exception)
      {
        return false;
      }
      return true;
    }

  }
}
