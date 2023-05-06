using GraditeljDomaci.classes.user.person;
using GraditeljDomaci.classes.user.rank;
using GraditeljDomaci.classes.user.teacher;
using System.ComponentModel.DataAnnotations;

try
{
    // Primer dodavanja osobe
    Console.WriteLine("Primer dodavanja osobe:");
    var osoba = PersonDirector
    .Builder()
    .Jmbg("1234678194171")
    .Name("Ensar")
    .Surname("Hamzic")
    .Gender('M')
    .Build();

    Console.WriteLine(osoba);
    Console.WriteLine("\n");

    // Primer dodavanja zvanja
    Console.WriteLine("Primer dodavanja zvanja:");
    var zvanje = RankDirector
    .Builder()
    .Id(1)
    .Name("Profesor")
    .Build();

    Console.WriteLine(zvanje);
    Console.WriteLine("\n");

    // Primer dodavanja nastavnika na nacin da je zvanje prethodno definisano
    Console.WriteLine("Primer dodavanja nastavnika na nacin da je zvanje prethodno definisano:");
    var nastavnik = TeacherDirector
        .Builder()
        .Jmbg("1234678194171")
        .Name("Ulfeta")
        .Surname("Marovac")
        .Gender('Z')
        .Rank(zvanje)
        .Birthday(new DateOnly(1990, 1, 1))
        .YearsOfService(15)
        .Build();

    Console.WriteLine(nastavnik);
    Console.WriteLine("\n");

    // Primer dodavanja nastavnika na nacin da je zvanje definisano u samom pozivu
    Console.WriteLine("Primer dodavanja nastavnika na nacin da je zvanje definisano u samom pozivu:");
    var asistent = TeacherDirector
        .Builder()
        .Jmbg("1111111123456")
        .Name("Safet")
        .Surname("Purkovic")
        .Gender('M')
        .Rank(
            RankDirector
                .Builder()
                .Id(2)
                .Name("Asistent")
                .Build()
            )
        .Birthday(new DateOnly(1985, 5, 7))
        .YearsOfService(3)
        .Build();

    Console.WriteLine(asistent);


}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
