using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLibrary.DataAccess
{
    public interface IDataConnection
    {
        CourseModel CreateCourse(CourseModel model, CreateModify cm);
        List<CourseModel> GetCourse_All();
    }
}
