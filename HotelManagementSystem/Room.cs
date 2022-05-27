using HotelManagementSystem.Enums;
using HotelManagementSystem.Interfaces;

using System;

namespace HotelManagementSystem
{
    public class Room : ISearch
    {
        private string _roomNumber;
        private RoomStyle _style;
        private RoomStatus _status;
        private double _bookingPrice;
        private bool _isSmoking;
        public bool SearchRoom(RoomStyle roomStyle, DateTime startDate, int duration)
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable()
        {
            return _status == RoomStatus.Available;
        }

        public bool CheckIn()
        {
            try
            {
                _status = RoomStatus.Occupied;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool CheckOut()
        {
            try
            {
                _status = RoomStatus.Available;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}