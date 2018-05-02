namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            float d = 91.5f;
            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeBook book2 = book;
            book2.AddGrade(75);
      
        }
    }
}
