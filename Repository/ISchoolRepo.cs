using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFunctionApp.Repository
{
    public interface ISchoolRepo
    {
        void updateCreditScore(int courseid, int studentid);
    }
}
