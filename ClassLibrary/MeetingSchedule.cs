using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();

        public void SetMeeting(string fullname,DateTime from, DateTime to)
        {
            if (!Meetings.Exists(x=>(x.FromDate<from || x.FromDate<to) && (x.ToDate>x.FromDate || x.ToDate>x.FromDate)))
            {
                Meetings.Add(new Meeting() { Name = fullname, FromDate = from, ToDate = to });
            }
            else
            {
                throw new Exception("vaxt uygun deyil");
            }
        }

        public int FindMeetingsCount(DateTime date)
        {
            return Meetings.FindAll(x => x.FromDate > date).Count;
        }

        public bool IsExistsMeetingByName(string name)
        {
            return Meetings.Exists(x=>x.Name == name);
        }

        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(x => x.Name.Contains(name));
        }
    }
}
