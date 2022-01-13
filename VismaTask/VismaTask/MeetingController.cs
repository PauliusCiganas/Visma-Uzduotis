using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask
{
    public static class MeetingController
    {
        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("creating new meeting ...");
            var testas = new Meeting()
            {
                Name = "testName",
                ResponsiblePerson = "testPerson",
                Description = "testDescription",
                Category = Category.Short,
                Type = Type.InPerson,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            };
            DB.Meetings.Add(testas);
            DB.SaveChanges();
        }

        public static void Delete()
        {
            Console.Clear();
            Console.WriteLine("delete meeting ...");
        }

        public static void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("adding person to meeting ..."); 
        }

        public static void RemovePerson()
        {
            Console.Clear();
            Console.WriteLine("removing person from meeting ...");
        }

        public static void GetAll() 
        {
            Console.Clear();
            Console.WriteLine("showing all meetings ...");
        }
    }
   
}
