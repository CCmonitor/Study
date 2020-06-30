using Dapper;
using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
namespace _Reflect_ORM
{
    class Orm
    {

        //约定：1类名和表名一样
        //2。字段名和数据库列名一样
        //3.主键的名字必须脚ID,必须是自动递增，int类型
        public static void Insert(Object obj)
        {
            //获得Obj对象的类名
            Type type = obj.GetType();
            string className = type.Name;

            PropertyInfo[] propinfos = type.GetProperties();

            //列名的数组
            var propNames = new string[propinfos.Length - 1];//排除掉Id
            //参数的名字
            var paramNames = new string[propinfos.Length - 1];

            var sqlparameters = new SqlParameter[propinfos.Length - 1];

            int count = 0;
            foreach (var propinfo in propinfos)
            {
                var propName = propinfo.Name;
                if (propName != "Id")
                {
                    propNames[count] = propName;
                    paramNames[count] = "@" + propName;
                    var sqlparameter = new SqlParameter();
                    sqlparameter.ParameterName = "@" + propName;
                    sqlparameter.Value = propinfo.GetValue(obj, null);//取obj对象的属性值
                    sqlparameters[count] = sqlparameter;
                    count++;
                }
            }
            string colnames = string.Join(",", propNames);

            //拼接生成的insert语句
            StringBuilder sbSQL = new StringBuilder();
            //insert into person(Name.Age) values(@Name,@Age)
            sbSQL.Append("Insert into ").Append(className).Append("(");
            sbSQL.Append(string.Join(",", propNames)).Append(")");
            sbSQL.Append(" values(").Append(string.Join(",", paramNames)).Append(")");

            var connectionString = "Data Source=116.228.237.198;Initial Catalog=test_caientao;User ID=sa;Pwd=51530018ab!;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Execute(sbSQL.ToString(), new {
                Name=111,
                Age=20,
            });
            ////SqlHelp
        }
    }
}
