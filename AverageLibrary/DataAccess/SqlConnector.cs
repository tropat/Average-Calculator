using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        private const string db = "Courses";
        public CourseModel CreateCourse(CourseModel model, CreateModify cm)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Ects", model.Ects);
                p.Add("@Grade", model.Grade);

                const string create = "dbo.spCourses_Insert";
                const string modify = "dbo.spCourses_Modify";
                string sp = "";

                switch(cm)
                {
                    case CreateModify.Create:
                        sp = create;
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        break;
                    case CreateModify.Modify:
                        sp = modify;
                        break;
                }

                connection.Execute(sp, p, commandType: CommandType.StoredProcedure);

                if(cm==CreateModify.Create)
                {
                    model.Id = p.Get<int>("@id");
                }

                return model;
            }
        }

        public List<CourseModel> GetCourse_All()
        {
            List<CourseModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CourseModel>("dbo.spCourses_GetAll").ToList();
            }
            return output;
        }
    }
}
