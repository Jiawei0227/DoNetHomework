using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Homwork3
{
    class MyDataBaseModel
    {
        private volatile static MyDataBaseModel myDataBaseModel;
        private static readonly object lockHelper = new Object();
        private MyDataBaseModel(){}
        public MyDataBaseModel getInstance()
        {
            if (myDataBaseModel == null)
            {
                lock (lockHelper)
                {
                    if (myDataBaseModel == null)
                    {
                        return new MyDataBaseModel();
                    }
                }
            }
            return myDataBaseModel;
        }

        public static bool deleteCourse(int id)
        {
            string constr = "Data Source=magic;Initial catalog=SuperCourse;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            String deleteStr = "delete from course where id=" + id;
            SqlCommand sqlcommand = new SqlCommand(deleteStr,conn);
            int sdr;
            try
            {
                sdr = sqlcommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
       
        }

        public static bool addNewCourse(Course newCourse){
            string constr = "Data Source=magic;Initial catalog=SuperCourse;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            int i;
            if(newCourse.IsBixiu)
                i=1;
            else
                i=0;
            string insertStr = "insert into course values('" + newCourse.ClassName + "','"+ newCourse.Teacher + "','" + newCourse.Classroom + "'," + newCourse.Score + "," + i + "," + newCourse.Hour + ")";
            SqlCommand sqlcommend = new SqlCommand(insertStr,conn);
            sqlcommend.CommandType = System.Data.CommandType.Text;
            int sdr;
            try
            {
                sdr = sqlcommend.ExecuteNonQuery();
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }


    }
}
