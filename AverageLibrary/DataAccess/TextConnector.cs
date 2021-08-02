using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string CourseFile = "CourseModels.csv";
        public CourseModel CreateCourse(CourseModel model, CreateModify cm)
        {
            List<CourseModel> courses = CourseFile.FullFilePath().LoadFile().ConvertToCourseModels();

            if(cm == CreateModify.Create)
            {
                int currentId = 1;
                if(courses.Count > 0)
                {
                    currentId = courses.OrderByDescending(x => x.Id).First().Id + 1;
                }
                
                model.Id = currentId;
                courses.Add(model);
            }
            else if(cm == CreateModify.Modify)
            {
                courses = courses.Modify(model);
            }

            courses.SaveToCoursesFile(CourseFile);

            return model;
        }

        public List<CourseModel> GetCourse_All()
        {
            return CourseFile.FullFilePath().LoadFile().ConvertToCourseModels();
        }
    }
}
