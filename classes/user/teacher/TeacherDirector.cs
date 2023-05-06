namespace GraditeljDomaci.classes.user.teacher
{
    public static class TeacherDirector
    {
        public static ITeacherBuilder PersonBuilder()
        {
            return new ConcreteTeacherBuilder();
        }
    }
}
