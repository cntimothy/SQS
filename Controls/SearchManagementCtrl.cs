using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SQS.Controller
{
    public class SearchManagementCtrl
    {
        /// <summary>
        /// 搜索论文结果
        /// </summary>
        /// <param name="paperResult">包含搜索结果的table</param>
        /// <param name="name">姓名（可为空）</param>
        /// <param name="depart">部系名称（可为空，为空时处室名称必为空）</param>
        /// <param name="office">处室名称（可为空）</param>
        /// <param name="startYear">开始年份</param>
        /// <param name="stopYear">结束年份</param>
        /// <param name="exception"></param>
        /// <returns>查询到结果返回true，否则返回false</returns>
        public static bool SearchPaper(ref DataTable paperResult, string name, string depart, string office, string startYear, string stopYear, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 搜索著作结果
        /// </summary>
        /// <param name="paperResult">包含搜索结果的table</param>
        /// <param name="name">姓名（可为空）</param>
        /// <param name="depart">部系名称（可为空，为空时处室名称必为空）</param>
        /// <param name="office">处室名称（可为空）</param>
        /// <param name="startYear">开始年份</param>
        /// <param name="stopYear">结束年份</param>
        /// <param name="exception"></param>
        /// <returns>查询到结果返回true，否则返回false</returns>
        public static bool SearchBook(ref DataTable bookResult, string name, string depart, string office, string startYear, string stopYear, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 搜索课题结果
        /// </summary>
        /// <param name="paperResult">包含搜索结果的table</param>
        /// <param name="name">姓名（可为空）</param>
        /// <param name="depart">部系名称（可为空，为空时处室名称必为空）</param>
        /// <param name="office">处室名称（可为空）</param>
        /// <param name="startYear">开始年份</param>
        /// <param name="stopYear">结束年份</param>
        /// <param name="exception"></param>
        /// <returns>查询到结果返回true，否则返回false</returns>
        public static bool SearchTopic(ref DataTable topicResult, string name, string depart, string office, string startYear, string stopYear, ref string exception)
        {
            return true;
        }
    }
}
