using Domain;
using System.Linq;

namespace ExercicesLinq;

internal class Program
{
    static void Main(string[] args)
    {
        DataContext dc = new DataContext();

        // exo 2.1

        //var result = dc.Students.Select(s => new
        //{
        //    s.First_Name,
        //    s.Last_Name,
        //    s.BirthDate,
        //    s.Login,
        //    s.Year_Result
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.First_Name} {s.Last_Name} {s.BirthDate} {s.Login} {s.Year_Result}");
        //}

        // exo 2.2

        //var result = dc.Students.Select(s => new
        //{
        //    Name = $"{s.Last_Name} {s.First_Name}",
        //    s.Student_ID,
        //    s.BirthDate
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Name} - {s.Student_ID} - {s.BirthDate}");
        //}

        // exo 2.3

        //var result = dc.Students.Select(s => new
        //{
        //    info = $"{s.First_Name}|{s.Last_Name}|{s.Login}|{s.Section_ID}|{s.Student_ID}|{s.Year_Result}|{s.BirthDate}"
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine(s.info);
        //}

        //3

        //3.1
    }
}
