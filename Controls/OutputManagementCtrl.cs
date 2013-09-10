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
        /// <param name="departScoreList"></param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetScoreResult(ref List<DepartScore> departScoreList, string startDate, string stopDate, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取各个处室各等级科研成果数量输出总表（按部系排序、注意相同成果只能算一篇）
        /// </summary>
        /// <param name="table">(Depart, Office, PaperPublishGrade1~4, PaperRewardGrade1~3, PaperRewardClass1~3, BookPublishGrade1~3, BookRewardGrade1~3, BookRewardClass1~3, TopicPublishGrade1~4, TopicRewardGrade1~3, TopicRewardClass1~3)</param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetCountResultForOffice(ref DataTable table, string startDate, string stopDate, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取各个部系各等级科研成果数量输出总表（按部系排序、注意相同成果只能算一篇）
        /// </summary>
        /// <param name="table">(Depart, PaperPublishGrade1~4, PaperRewardGrade1~3, PaperRewardClass1~3, BookPublishGrade1~3, BookRewardGrade1~3, BookRewardClass1~3, TopicPublishGrade1~4, TopicRewardGrade1~3, TopicRewardClass1~3)</param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetCountResultDepart(ref DataTable table, string startDate, string stopDate, ref string exception)
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
