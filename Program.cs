using GraditeljDomaci.classes.user.person;
using GraditeljDomaci.classes.user.teacher;

try
{
    var p = PersonDirector
    .PersonBuilder()
    .Jmbg("1234678194171")
    .Name("Ensar")
    .Surname("Hamzic")
    .Gender('M')
    .Build();

    Console.WriteLine("Uneta osoba:");
    Console.WriteLine(p);

    var t = TeacherDirector
        .PersonBuilder()
        .Jmbg("1234678194171")
        .Name("Ensar")
        .Surname("Hamzic")
        .Gender('M')
        .Rank("Docent")
        .Birthday(new DateOnly(1990, 1, 1))
        .YearsOfService(5)
        .Build();

    Console.WriteLine("Uneta osoba:");
    Console.WriteLine(t);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
