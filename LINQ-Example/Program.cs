using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LINQExample
{
  class Program
  {
    static void Main(string[] args)
    {
      var StudentList = StudentDatabase.GetStudentsFromDb();


      var query1 = StudentList.Where(x => x.IsActive == true &&
                                          x.Score > 80 &&
                                          x.City == "NYC");

      var query2 = StudentList.Where(x => x.Score > 80 ||
                                          x.City == "CA")
                              .Select(x => x.StudentName);

      var query3 = StudentList.Where(x => x.StudentName.ToUpper().StartsWith('B'))
                              .Select(x => new MinimalStudent()
                              {
                                StudentName = x.StudentName,
                                Score = x.Score
                              });

      var query4 = StudentList.Where(x => x.IsActive == false)
                              .OrderByDescending(x => x.Score);

      var query5 = StudentList.Average(x => x.Score);
 

      var query6 = StudentList.Where(x => x.City == "CA")
                              .Where(x => x.IsActive &&
                                    (x.StudentName.ToLower().Contains('d') ||
                                     x.StudentName.ToLower().Contains('r')))
                               .Average(x => x.Score);

    }
  }
}
