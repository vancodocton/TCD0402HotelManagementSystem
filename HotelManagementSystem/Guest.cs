using HotelManagementSystem.Enums;
using HotelManagementSystem.Interfaces;

using System;

namespace HotelManagementSystem
{
    public class Guest
    {
        private ISearch _searchService;
        public Guest(ISearch searchService)
        {
            _searchService = searchService;
        }

        public bool Search(RoomStyle style, DateTime startDate, int duration)
        {
            return _searchService.SearchRoom(style, startDate, duration);
        }
    }
}