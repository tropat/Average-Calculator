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
        public string Name { get; set; }
        public int Ects { get; set; }
        public float Grade { get; set; }
    }
}