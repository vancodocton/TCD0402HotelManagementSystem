
using HotelManagementSystem.Enums;

using System;

namespace HotelManagementSystem.Interfaces
{
  public interface ISearch
  {
    bool SearchRoom(RoomStyle roomStyle, DateTime startDate, int duration);
  }
}