using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Conferences
{
    internal class Conference
    {
        public enum Room
        {
            ROOM_101 = 100,
            ROOM_102 = 102,
            ROOM_201 = 201,
            ROOM_202 = 202,
            ROOM_301 = 301,
            ROOM_302 = 302
        }
        protected string _room;
        protected int _attendees;
        protected string _groupName;
        protected DateTime _date;
        public Conference(string groupname, DateTime date, int attendees, string room )
        {
            _room = room;
            _attendees = attendees;
            _groupName = groupname;
            _date = date;
        }
        public string room
        {
            get { return _room; }
            set { _room = value; }
        }
        public int attendees
        {
            get { return _attendees; }
            set { _attendees = value; }
        }
        public DateTime date
        {
            get { return _date; }   
            set { _date = value; }
        }
        public string groupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
        public override string ToString()
        {
            return  "(" + attendees  + ")" + " "+ " " + groupName + " "  + " "+ date.ToString("MMM dd, yyyy") + " " + room;
        }


    }
}
