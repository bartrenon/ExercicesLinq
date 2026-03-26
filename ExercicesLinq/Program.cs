using Domain;
using System.Linq;

namespace ExercicesLinq;

internal class Program
{
    static void Main(string[] args)
    {
        DataContext dc = new DataContext();

        // Select
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

        //3 where et orderBy

        //3.1

        //var result = dc.Students.Where(s => s.BirthDate.Year < 1955).
        //Select(s => new
        //{
        //    s.Last_Name,
        //    s.Year_Result,
        //    Statut = s.Year_Result >= 12 ? "OK" : "KO"
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Last_Name} - {s.Year_Result} - {s.Statut}");
        //}

        //3.2

        /*var result = dc.Students.Where(s => s.BirthDate.Year >= 1955 && s.BirthDate.Year <= 1965).
        Select(s => new
        {
            s.Last_Name,
            s.Year_Result,
            Categorie = s.Year_Result < 10 ? "inférieure" :
                s.Year_Result == 10 ? "neutre" :
                    "supérieure"
        });

        foreach (var s in result)
        {
            Console.WriteLine($"{s.Last_Name} - {s.Year_Result} - {s.Categorie}");
        }*/

        //3.3

        //var result = dc.Students.Where(s => s.Last_Name.EndsWith("r")).
        //Select(s => new
        //{
        //    s.Last_Name,
        //    s.Section_ID
        //});

        // foreach (var s in result)
        // {
        //     Console.WriteLine($"{s.Last_Name} - {s.Section_ID}");
        // }

        //3.4

        //var result = dc.Students.Where(s => s.Year_Result <= 3).
        //    OrderByDescending(s => s.Year_Result).
        //Select(s => new
        //{
        //    s.Last_Name,
        //    s.Year_Result
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Last_Name} - {s.Year_Result}");
        //}

        //3.5

        //var result = dc.Students.Where(s => s.Section_ID == 1110).
        //    OrderBy(s => s.Last_Name).
        //Select(s => new
        //{
        //    Name = $"{s.Last_Name} {s.First_Name}",
        //    s.Year_Result
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Name} - {s.Year_Result}");
        //}

        //3.6

        //var result = dc.Students.Where(s => (s.Section_ID == 1010 || s.Section_ID == 1020) && (s.Year_Result < 12 || s.Year_Result > 18)).
        //    OrderBy(s => s.Section_ID).
        //Select(s => new
        //{
        //    s.Last_Name,
        //    s.Section_ID,
        //    s.Year_Result
        //});

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Last_Name} - {s.Section_ID} - {s.Year_Result}");
        //}

        //3.7

        //var result = dc.Students.Where(s => s.Section_ID.ToString().StartsWith("13")).
        //Select(s => new
        //{
        //    s.Last_Name,
        //    s.Section_ID,
        //    result_100 = s.Year_Result * 5
        //}).Where(s => s.result_100 <+ 60).OrderByDescending(s => s.result_100);

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Last_Name} - {s.Section_ID} - {s.result_100}");
        //}

        //4 COUNT MIN MAX SUM AVRAGE

        // 4.1 

        //var moyenne = dc.Students.Average(s => s.Year_Result);

        //Console.WriteLine(moyenne);

        // 4.2 

        //var max = dc.Students.Max(s => s.Year_Result);
        //Console.WriteLine(max);

        // 4.3

        //var sum = dc.Students.Sum(s => s.Year_Result);
        //Console.WriteLine(sum);

        // 4.4

        //var min = dc.Students.Min(s => s.Year_Result);
        //Console.WriteLine(min);

        // 4.5

        //var min = dc.Students.Where(s => s.Year_Result % 2 != 0).Count();
        //Console.WriteLine(min);

        // 5 groupeBy Join GroupJoin 

        //5.1

        //var result = dc.Students.GroupBy(s => s.Section_ID)
        //   .Select(g => new 
        //   {
        //        Section = g.Key,
        //        MaxResult = g.Max(s => s.Year_Result)
        //    });

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"Section {s.Section} : Max = {s.MaxResult}");
        //}

        // 5.2

        //var result = dc.Students.Where(s => s.Section_ID.ToString().StartsWith("10"))
        //   .GroupBy(s => s.Section_ID)
        //   .Select(g => new
        //   {
        //       Section = g.Key,
        //       MoySection = g.Average(s => s.Year_Result)
        //   });

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"Section {s.Section} : AVG = {s.MoySection}");
        //}

        // 5.3

        //var result = dc.Students.Where(s => s.BirthDate.Year >= 1970 && s.BirthDate.Year <= 1985)
        //   .GroupBy(s => s.BirthDate.Month)
        //   .Select(g => new
        //   {
        //       BirthMonth = g.Key,
        //       AVGResult = g.Average(s => s.Year_Result)
        //   });

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.BirthMonth} : AVG = {s.AVGResult}");
        //}

        // 5.4

        //var result = dc.Students.GroupBy(s => s.Section_ID)
        //   .Where(s => s.Count() > 3)
        //   .Select(g => new
        //   {
        //       Section = g.Key,
        //       AVGResult = g.Average(s => s.Year_Result)
        //   });

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Section} : AVG = {s.AVGResult}");
        //}

        // 5.5

        //var result = dc.Courses
        //    .Join(dc.Professors,
        //        c => c.Professor_ID,
        //        p => p.Professor_ID,
        //        (c, p) => new { c, p })
        //    .Join(dc.Sections,
        //        cp => cp.p.Section_ID,
        //        s => s.Section_ID,
        //        (cp, s) => new {
        //            cp.c.Course_Name,
        //            s.Section_Name,
        //            cp.p.Professor_Name
        //        }).OrderBy(c => c.Course_Name);



        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Course_Name} : {s.Section_Name} : {s.Professor_Name}");
        //}

        // 5.6

        //var result = dc.Sections
        //    .Join(dc.Students,
        //        s => s.Delegate_ID,
        //        su => su.Student_ID,
        //        (s, su) => new {
        //            s.Section_ID,
        //            s.Section_Name,
        //            su.Last_Name
        //        }).OrderByDescending(s => s.Section_ID);



        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Section_ID} : {s.Section_Name} : {s.Last_Name}");
        //}

        // 5.7

        //var result = dc.Sections.Select(s => new
        //{
        //    s.Section_ID,
        //    s.Section_Name
        //});



        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Section_ID} - {s.Section_Name}\n");

        //    var InfoProf = dc.Professors.Where(p => p.Section_ID == s.Section_ID)
        //    .Select(p => new
        //     {
        //         p.Professor_Name
        //     });

        //    foreach (var p in InfoProf) 
        //    {
        //        Console.WriteLine($"     - {p.Professor_Name}");
        //    }

        //    Console.WriteLine();
        //}

        // 5.8

        //var result = dc.Sections
        //    .GroupJoin(dc.Professors,
        //     s => s.Section_ID,
        //     p => p.Section_ID,
        //     (s, p) => new
        //     {
        //         s.Section_ID,
        //         s.Section_Name,
        //         Processors = p
        //     }).Where( x => x.Processors.Any());


        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Section_ID} - {s.Section_Name}\n");

        //    foreach (var p in s.Processors)
        //    {
        //        Console.WriteLine($"     - {p.Professor_Name}");
        //    }

        //    Console.WriteLine();
        //}

        //5.9

        //var result = dc.Students
        //.Where(s => s.Year_Result >= 12)
        //.SelectMany(s => dc.Grades
        //.Where(g => s.Year_Result >= g.Lower_Bound && s.Year_Result <= g.Upper_Bound),
        //(s, g) => new
        //{
        //    s.Last_Name,
        //    s.Year_Result,
        //    Grade = g.GradeName
        //})
        //.OrderBy(x => x.Grade);

        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Last_Name} - {s.Year_Result} - {s.Grade}");
        //}

        //5.10

        //var result = dc.Professors
        //    .Join(dc.Sections,
        //        p => p.Section_ID,
        //        s => s.Section_ID,
        //        (p, s) => new { p, s })
        //    .GroupJoin(dc.Courses,
        //        ps => ps.p.Professor_ID,
        //        c => c.Professor_ID,
        //        (ps, c) => new { ps, c })
        //        .SelectMany(
        //         psc => psc.c.DefaultIfEmpty(),
        //         (psc, x) => new
        //        {
        //            psc.ps.p.Professor_Name,
        //            psc.ps.s.Section_Name,
        //            x?.Course_Name,
        //            x?.Course_Ects 
        //        }).OrderByDescending(p => p.Course_Ects).ThenBy(p => p.Professor_Name);



        //foreach (var s in result)
        //{
        //    Console.WriteLine($"{s.Professor_Name} : {s.Section_Name} : {s.Course_Name} : {s.Course_Ects}");
        //}

        //5.11
        var result = dc.Professors
            .GroupJoin(dc.Courses,
             p => p.Professor_ID,
             c => c.Professor_ID,
             (p, c) => new
             {
                 p.Professor_ID,
                 ECTSTOT = c.Sum(c => c.Course_Ects)
             }).OrderByDescending(p => p.ECTSTOT);


        foreach (var s in result)
        {
           Console.WriteLine($"{s.Professor_ID} : {s.ECTSTOT}");
        }


    }
}
