using System;
using ClassLibrary;
namespace CSharp_File_Directory_Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting01 = new Meeting();
            meeting01.Name = "interview01";
            meeting01.FromDate = new DateTime(2022,4,13,12,24,0);
            meeting01.ToDate = new DateTime(2022,4,13,13,0,0);

            Meeting meeting02 = new Meeting();
            meeting02.Name = "interview02";
            meeting02.FromDate = new DateTime(2022, 4, 13, 13, 24, 0);
            meeting02.ToDate = new DateTime(2022, 4, 13, 14, 0, 0);

            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.Meetings.Add(meeting01);
            meetingSchedule.Meetings.Add(meeting02);
            DateTime from = new DateTime(2022, 4, 13, 11, 25, 0);
            DateTime to = new DateTime(2022, 4, 13, 12, 0, 0);
            meetingSchedule.SetMeeting("interview03", from, to);

            Console.WriteLine("=============All Meetings=============\n");
            foreach (var item in meetingSchedule.Meetings)
            {
                Console.WriteLine(item.Name+"\n");
            }

            Console.WriteLine("=============Find Meetings Count=============\n");
            Console.WriteLine(meetingSchedule.FindMeetingsCount(new DateTime(2022, 4, 13, 11, 30, 0)) + "\n");

            Console.WriteLine("=============Is Exists Meeting By Name=============\n");
            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("interview"));

            Console.WriteLine("=============Get Exist Meetings=============\n");
            foreach (var item in meetingSchedule.GetExistMeetings("interview"))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
