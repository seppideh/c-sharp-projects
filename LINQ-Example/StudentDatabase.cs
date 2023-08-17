using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQExample
{
  public class StudentDatabase
  {
    public static IQueryable<Student> GetStudentsFromDb()
    {
      return new[] {
            new Student() {StudentID=1 , StudentName="John Nigel" , Score=73 , City="NYC" , IsActive=true},
            new Student() {StudentID=2 , StudentName="Alex Roma" , Score=51 , City="CA", IsActive=true},
            new Student() {StudentID=3 , StudentName="Noha Shamil" , Score=88 , City="CA", IsActive=false},
            new Student() {StudentID=4 , StudentName="James Palatte" , Score=60 , City="NYC", IsActive=true},
            new Student() {StudentID=5 , StudentName="Ron Jenova" , Score=85 , City="NYC", IsActive=true},
            new Student() {StudentID=6 , StudentName="Donya Malekpour" , Score=90 , City="NYC" , IsActive=false},
            new Student() {StudentID=7 , StudentName="Ashkan Romans" , Score=51 , City="CA", IsActive=false},
            new Student() {StudentID=8 , StudentName="Dorsa Lenova" , Score=95 , City="CA", IsActive=true},
            new Student() {StudentID=9 , StudentName="Jimmy Palat" , Score=65 , City="NYC", IsActive=false},
            new Student() {StudentID=10 , StudentName="Bita Tahmasb" , Score=45 , City="NYC", IsActive=true}
        }.AsQueryable();
    }
  }
}