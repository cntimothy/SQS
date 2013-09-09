using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQS.DataStructure;

namespace SQS.Controller
{
    public class OutputManagementCtrl
    {
        /// <summary>
        /// 获取输出总表
        /// </summary>
        /// <param name="depart">包含所有信息的数据结构</param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetResult(ref List<DepartScore> depart, string startDate, string stopDate, ref string exception)
        {
            return true;
        }
    }
}
