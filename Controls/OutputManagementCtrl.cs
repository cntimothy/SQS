using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQS.DataStructure;
using System.Data;

namespace SQS.Controller
{
    public class OutputManagementCtrl
    {
        /// <summary>
        /// 获取分数输出总表
        /// </summary>
        /// <param name="depart">包含所有信息的数据结构</param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetScoreResult(ref List<DepartScore> depart, string startDate, string stopDate, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取数量输出总表
        /// </summary>
        /// <param name="table"></param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetCountResult(ref DataTable table, string startDate, string stopDate, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取论文发表级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">论文发表级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetPublishGradeNameListForPaper(ref List<string> nameList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取著作发行级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">著作发行级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetPublishGradeNameListForBook(ref List<string> nameList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取课题级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">课题级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetTopicGradeNameList(ref List<string> nameList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取奖励级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">奖励级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetRewardGrade(ref List<string> nameList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取奖励等级名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">奖励等级名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetRewardClass(ref List<string> nameList, ref string exception)
        {
            return true;
        }
    }
}
