using SchoolFunctionApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFunctionApp.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepo _schoolRepo;

        public SchoolService(ISchoolRepo schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }
        public void ProcessRequest(int courseid, int studentid)
        {
            _schoolRepo.updateCreditScore(courseid, studentid);
        }
    }
}
