using System.Collections.Generic;

namespace HotelManagementSystem
{
  public class HotelLocation
  {
    private string _name;
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _location;

    public HotelLocation(string name, string location)
    {
      _name = name;
      _location = location;
    }

    public string Location
    {
      get { return _location; }
      set { _location = value; }
    }

    private List<Room> _rooms = new List<Room>();
    public List<Room> GetRooms()
    {
      return _rooms;
    }




  }
}