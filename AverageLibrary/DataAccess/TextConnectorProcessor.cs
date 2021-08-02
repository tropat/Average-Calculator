using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<CourseModel> ConvertToCourseModels(this List<string> lines)
        {
            List<CourseModel> output = new List<CourseModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split('|');

                CourseModel c = new CourseModel();
                c.Id = int.Parse(cols[0]);
                c.Name = cols[1];
                c.Ects = int.Parse(cols[2]);
                c.Grade = double.Parse(cols[3]);

                output.Add(c);
            }
            return output;
        }
        public static List<CourseModel> Modify(this List<CourseModel> courses, CourseModel model)
        {
            foreach(CourseModel c in courses)
            {
                if(c.Name == model.Name)
                {
                    c.Ects = model.Ects;
                    c.Grade = model.Grade;
                }
            }
            return courses;
        }
        public static void SaveToCoursesFile(this List<CourseModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(CourseModel c in models)
            {
                lines.Add($"{c.Id}|{c.Name}|{c.Ects}|{c.Grade}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
