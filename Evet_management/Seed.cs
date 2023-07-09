// using Evet_management.models; // Update with the correct namespace for your Event model
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using System;

// namespace Evet_management.Data
// {
//     public class Seed 
//     {
//         public void Initialize(ModelBuilder modelBuilder)
//         {
//             // Seed at least five dummy data entries for the Events table
//             modelBuilder.Entity<Event>().HasData(
//                 new Event
//                 {
//                     Id = 1,
//                     Event_Name = "Event 1",
//                     Event_Topic = "Topic 1",
//                     Start_Time = DateTime.Now,
//                     End_Time = DateTime.Now.AddHours(2),
//                     Payment = 100
//                 },
//                 new Event
//                 {
//                     Id = 2,
//                     Event_Name = "Event 2",
//                     Event_Topic = "Topic 2",
//                     Start_Time = DateTime.Now.AddDays(1),
//                     End_Time = DateTime.Now.AddDays(1).AddHours(3),
//                     Payment = 150
//                 },
//                 new Event
//                 {
//                     Id = 3,
//                     Event_Name = "Event 3",
//                     Event_Topic = "Topic 3",
//                     Start_Time = DateTime.Now.AddDays(2),
//                     End_Time = DateTime.Now.AddDays(2).AddHours(4),
//                     Payment = 200
//                 },
//                 new Event
//                 {
//                     Id = 4,
//                     Event_Name = "Event 4",
//                     Event_Topic = "Topic 4",
//                     Start_Time = DateTime.Now.AddDays(3),
//                     End_Time = DateTime.Now.AddDays(3).AddHours(2),
//                     Payment = 120
//                 },
//                 new Event
//                 {
//                     Id = 5,
//                     Event_Name = "Event 5",
//                     Event_Topic = "Topic 5",
//                     Start_Time = DateTime.Now.AddDays(4),
//                     End_Time = DateTime.Now.AddDays(4).AddHours(3),
//                     Payment = 180
//                 }
//             );
//         }

//         internal void Initialize(object modelBuilder)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }
