using ConsoleAppTaskdop1hw0502.Context;
using ConsoleAppTaskdop1hw0502.Models;

namespace ConsoleAppTaskdop1hw0502
{
    class Program
    {
        static void Main(string[] args)
        {
            //    using (var db = new Applicationtext())
            //    {
            //        var AssignmentToAdd = new List<Assignment>
            //{
            //new Assignment { Name = "Разработка проекта", StartDate = new DateTime(2024, 2, 1), EndDate = new DateTime(2024, 2, 15) },
            //new Assignment { Name = "Тестирование модулей", StartDate = new DateTime(2024, 2, 16), EndDate = new DateTime(2024, 2, 25) },
            //new Assignment { Name = "Внедрение системы", StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2024, 3, 10) },
            //new Assignment { Name = "Подготовка документации", StartDate = new DateTime(2024, 3, 11), EndDate = new DateTime(2024, 3, 20) }
            // };

            //        db.Assignments.AddRange(AssignmentToAdd);
            //        db.SaveChanges();
            //    }
            //}
            //using (var db = new Applicationtext())
            //{
            //    var requiredWorkdays = 7;
            //    var Assignments = db.Assignments
            //        .Where(t => db.CalculateWorkdays(t.StartDate, t.EndDate) >= requiredWorkdays)
            //        .ToList();

            //    foreach (var Assignment in Assignments)
            //    {
            //        Console.WriteLine($"Assignment: {Assignment.Name}");
            //    }
            //}
            //using (var db = new Applicationtext())
            //{
            //    int minWorkdaysRequired = 5;

            //    // запрос, использующий функцию CalculateWorkdays для фильтрации задач
            //    var filteredAssignments = db.Assignments
            //        .Where(a => db.CalculateWorkdays(a.StartDate, a.EndDate) >= minWorkdaysRequired)
            //        .Select(a => new
            //        {
            //            a.Name,
            //            StartDate = a.StartDate,
            //            EndDate = a.EndDate,
            //            Workdays = db.CalculateWorkdays(a.StartDate, a.EndDate)
            //        })
            //        .ToList();
            //    foreach (var assignment in filteredAssignments)
            //    {
            //        Console.WriteLine($"Name: {assignment.Name}, StartDate: {assignment.StartDate.ToShortDateString()}, EndDate: {assignment.EndDate.ToShortDateString()}, Workdays: {assignment.Workdays}");
            //    }
            //}
        }
    }
}
