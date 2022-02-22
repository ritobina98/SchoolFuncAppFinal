using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFunctionApp.Services
{
    public interface ISchoolService
    {
       void ProcessRequest(int courseid, int studentid);
    }
}
