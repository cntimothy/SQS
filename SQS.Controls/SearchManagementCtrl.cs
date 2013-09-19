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
        /// <param name="paperTable">Depart, Office, Name, PaperName, JournalName, PublishDate, PublishGrade, RewardGrade, RewardClass, WordCount, AutherCount, Auther1, Auther2, Auther3</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>搜索成功且结果非空返回true，否则返回false</returns>
        public static bool SearchPaper(ref DataTable paperTable, SearchCondition searchCondition, ref string exception)
        {
            paperTable.Columns.Add("Depart");
            paperTable.Columns.Add("Office");
            paperTable.Columns.Add("Name");
            paperTable.Columns.Add("PaperName");
            paperTable.Columns.Add("JournalName");
            paperTable.Columns.Add("PublishDate");
            paperTable.Columns.Add("PublishGrade");
            paperTable.Columns.Add("RewardGrade");
            paperTable.Columns.Add("RewardClass");
            paperTable.Columns.Add("WordCount");
            paperTable.Columns.Add("AutherCount");
            paperTable.Columns.Add("Auther1");
            paperTable.Columns.Add("Auther2");
            paperTable.Columns.Add("Auther3"); 
            paperTable.Rows.Add("军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            paperTable.Rows.Add("军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            paperTable.Rows.Add("军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            paperTable.Rows.Add("军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            return true;
        }


        /// <summary>
        /// 搜索著作
        /// </summary>
        /// <param name="paperTable">(Depart, Office, Name, BookName, Press, PublishDate, PublishGrade, RewardGrade, RewardClass, WordCount, AutherCount, Auther1, Auther2, Auther3, Auther4, Auther5)</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>搜索成功且结果非空返回true，否则返回false</returns>
        public static bool SearchBook(ref DataTable bookTable, SearchCondition searchCondition, ref string exception)
        {
            bookTable.Columns.Add("Depart");
            bookTable.Columns.Add("Office");
            bookTable.Columns.Add("Name");
            bookTable.Columns.Add("BookName");
            bookTable.Columns.Add("Press");
            bookTable.Columns.Add("PublishDate");
            bookTable.Columns.Add("PublishGrade");
            bookTable.Columns.Add("RewardGrade");
            bookTable.Columns.Add("RewardClass");
            bookTable.Columns.Add("WordCount");
            bookTable.Columns.Add("AutherCount");
            bookTable.Columns.Add("Auther1");
            bookTable.Columns.Add("Auther2");
            bookTable.Columns.Add("Auther3");
            bookTable.Columns.Add("Auther4");
            bookTable.Columns.Add("Auther5");

            bookTable.Rows.Add("机关政治工作系", "宣传文化教研室", "杨明伟", "军队思想政治教育文化资源研究", "人民武警出版社", "2013.5", "内部发行", " ", " ", "4000", "3", "*", " ", " ", " ", " ");
            bookTable.Rows.Add("机关政治工作系", "宣传文化教研室", "杨明伟", "军队思想政治教育文化资源研究", "人民武警出版社", "2013.5", "内部发行", " ", " ", "4000", "3", "*", " ", " ", " ", " ");
            bookTable.Rows.Add("机关政治工作系", "宣传文化教研室", "杨明伟", "军队思想政治教育文化资源研究", "人民武警出版社", "2013.5", "内部发行", " ", " ", "4000", "3", "*", " ", " ", " ", " ");
            bookTable.Rows.Add("机关政治工作系", "宣传文化教研室", "杨明伟", "军队思想政治教育文化资源研究", "人民武警出版社", "2013.5", "内部发行", " ", " ", "4000", "3", "*", " ", " ", " ", " ");
            bookTable.Rows.Add("机关政治工作系", "宣传文化教研室", "杨明伟", "军队思想政治教育文化资源研究", "人民武警出版社", "2013.5", "内部发行", " ", " ", "4000", "3", "*", " ", " ", " ", " ");
            return true;
        }

        /// <summary>
        /// 搜索课题
        /// </summary>
        /// <param name="paperTable">(Depart, Office, Name, TopicName, TopicGrade, StartTime, StopTime, RewardGrade, RewardClass, CompleteType, WordCount, AutherCount, Auther1, Auther2, Auther3, Auther4, Auther5)</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>搜索成功且结果非空返回true，否则返回false</returns>
        public static bool SearchTopic(ref DataTable topicTable, SearchCondition searchCondition, ref string exception)
        {
            topicTable.Columns.Add("Depart");
            topicTable.Columns.Add("Office");
            topicTable.Columns.Add("Name");
            topicTable.Columns.Add("TopicName");
            topicTable.Columns.Add("TopicGrade");
            topicTable.Columns.Add("StartTime");
            topicTable.Columns.Add("StopTime");
            topicTable.Columns.Add("RewardGrade");
            topicTable.Columns.Add("RewardClass");
            topicTable.Columns.Add("CompleteType");
            topicTable.Columns.Add("WordCount");
            topicTable.Columns.Add("AutherCount");
            topicTable.Columns.Add("Auther1");
            topicTable.Columns.Add("Auther2");
            topicTable.Columns.Add("Auther3");
            topicTable.Columns.Add("Auther4");
            topicTable.Columns.Add("Auther5");
            topicTable.Rows.Add("机关政治工作系", "组织工作教研室", "王辉", "边疆民族地区维稳政治攻势研究", "武警部队军事理论课题", "2012年3月", "2012年10月", "武警部队", "三等奖", "研究报告", "50000", " ", " ", " ", "*", " ", " ");
            topicTable.Rows.Add("机关政治工作系", "组织工作教研室", "王辉", "边疆民族地区维稳政治攻势研究", "武警部队军事理论课题", "2012年3月", "2012年10月", "武警部队", "三等奖", "研究报告", "50000", " ", " ", " ", "*", " ", " ");
            topicTable.Rows.Add("机关政治工作系", "组织工作教研室", "王辉", "边疆民族地区维稳政治攻势研究", "武警部队军事理论课题", "2012年3月", "2012年10月", "武警部队", "三等奖", "研究报告", "50000", " ", " ", " ", "*", " ", " ");
            return true;
        }
    }
}
