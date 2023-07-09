using System;

namespace  Evet_management.models
{
    public class Event
    {
        public int Id { get; set; }
        public  string? Event_Name { get; set; }
        public  string? Event_Topic { get; set; }
        public  string? Event_Descriptions { get; set; }
        public  DateTime Start_Time { get; set; }
        public  DateTime End_Time { get; set; }
        public int Payment { get; set; }
    }

}