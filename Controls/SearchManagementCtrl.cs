using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SQS.DataStructure;

namespace SQS.Controller
{
    public class SearchManagementCtrl
    {
        /// <summary>
        /// 搜索论文
        /// </summary>
        /// <param name="paperTable">搜索论文结果</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>搜索成功且结果非空返回true，否则返回false</returns>
        public static bool SearchPaper(ref DataTable paperTable, SearchCondition searchCondition, ref string exception)
        {
            return true;
        }


        /// <summary>
        /// 搜索著作
        /// </summary>
        /// <param name="paperTable">搜索著作结果</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>搜索成功且结果非空返回true，否则返回false</returns>
        public static bool SearchBook(ref DataTable bookTable, SearchCondition searchCondition, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 搜索课题
        /// </summary>
        /// <param name="paperTable">搜索课题结果</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>搜索成功且结果非空返回true，否则返回false</returns>
        public static bool SearchTopic(ref DataTable topicTable, SearchCondition searchCondition, ref string exception)
        {
            return true;
        }
    }
}
