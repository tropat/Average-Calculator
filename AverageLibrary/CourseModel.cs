using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AverageLibrary
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ects { get; set; }
        public double Grade { get; set; }
        public string CompleteInformation
        {
            get
            {
                return $"{Name} - ECTS: {Ects} Grade: {Grade}";
            }
        }
    }
}