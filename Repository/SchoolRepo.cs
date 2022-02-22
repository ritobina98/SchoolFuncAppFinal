using SchoolFunctionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFunctionApp.Repository
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly SchoolContext _schoolContext;

        public SchoolRepo(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public void updateCreditScore(int courseid, int studentid)
        {

            //SchoolContext obj = new SchoolContext();
            //obj.Courses

           var result= _schoolContext.StudentGrades.Where(x=>x.CourseId==courseid && x.StudentId==studentid).FirstOrDefault();
            result.Grade = result.Grade + 1;
            _schoolContext.SaveChanges();
            //
        }
    }
}
