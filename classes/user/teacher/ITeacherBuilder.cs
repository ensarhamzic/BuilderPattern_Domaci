using GraditeljDomaci.classes.user.rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.teacher
{
    public interface ITeacherBuilder
    {
        TeacherBuilder Rank(Rank rank);
        TeacherBuilder Birthday(DateOnly birthday);
        TeacherBuilder YearsOfService(int yearsOfService);
    }
}
