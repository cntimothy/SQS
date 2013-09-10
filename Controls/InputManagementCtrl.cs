using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SQS.DataStructure;

namespace SQS.Controller
{
    public class InputManagementCtrl
    {
        #region Paper
        /// <summary>
        /// 根据路径导入论文Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="createCount">新增数量</param>
        /// <param name="updateCount">更新数量</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportPaperExcel(string path, ref int createCount, ref int updateCount, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取所有论文信息
        /// </summary>
        /// <param name="table">（ID, Depart, Office, Name, PaperName, JournalName, PublishDate, PublishGrade, RewardGrade, RewardClass, WordCount, AutherCount, Auther1, Auther2, Auther3）</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllPaperInformation(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Depart");
            table.Columns.Add("Office");
            table.Columns.Add("Name");
            table.Columns.Add("PaperName");
            table.Columns.Add("JournalName");
            table.Columns.Add("PublishDate");
            table.Columns.Add("PublishGrade");
            table.Columns.Add("RewardGrade");
            table.Columns.Add("RewardClass");
            table.Columns.Add("WordCount");
            table.Columns.Add("AutherCount");
            table.Columns.Add("Auther1");
            table.Columns.Add("Auther2");
            table.Columns.Add("Auther3");
            table.Rows.Add("1", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("2", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("3", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("4", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("5", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("6", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("7", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("8", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("9", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("10", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("11", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("12", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("13", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("14", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("15", "基层政治工作系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("16", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("17", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("18", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("19", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("10", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("20", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("21", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("22", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("23", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("24", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("25", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("26", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("27", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("28", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("29", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            return true;
        }

        /// <summary>
        /// 根据搜索条件获取文论信息（部系、处室、发表级别、奖励级别、奖励等级均是获取名称，非ID）
        /// </summary>
        /// <param name="table">（ID, Depart, Office, Name, PaperName, JournalName, PublishDate, PublishGrade, RewardGrade, RewardClass, WordCount, AutherCount, Auther1, Auther2, Auther3）</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetPaperInformationByCondition(ref DataTable table, SearchCondition searchCondition, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Depart");
            table.Columns.Add("Office");
            table.Columns.Add("Name");
            table.Columns.Add("PaperName");
            table.Columns.Add("JournalName");
            table.Columns.Add("PublishDate");
            table.Columns.Add("PublishGrade");
            table.Columns.Add("RewardGrade");
            table.Columns.Add("RewardClass");
            table.Columns.Add("WordCount");
            table.Columns.Add("AutherCount");
            table.Columns.Add("Auther1");
            table.Columns.Add("Auther2");
            table.Columns.Add("Auther3");
            table.Rows.Add("1", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("2", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("3", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("4", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("5", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("6", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("7", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("8", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("9", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("10", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("11", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("12", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("13", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("14", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("15", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("16", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("17", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("18", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("19", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("10", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("20", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("21", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("22", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("23", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("24", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("25", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("26", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("27", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("28", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            table.Rows.Add("29", "军事安全保卫系", "刑侦", "张钢", "军地互涉刑事案件侦查管辖权限界分原则", "武警政治学院学报", "2013.01", "内部期刊", " ", " ", "3000", "1", "*", "", "");
            return true;
        }

        /// <summary>
        /// 根据记录ID获取论文信息
        /// </summary>
        /// <param name="paper">论文信息</param>
        /// <param name="id">记录ID</param>
        /// <param name="exception"></param>
        /// <returns>获取成功返回true，否则返回false</returns>
        public static bool GetPaperById(ref Paper paper, string id, ref string exception)
        {
            paper.Id = "12";
            paper.DepartId = "2";
            paper.OfficeId = "3";
            paper.Name = "高2";
            paper.PaperName = "论文名称";
            paper.JournalName = "会议名称";
            paper.PublishDate = "发表日期";
            paper.PublishGradeId = "3";
            paper.RewardGradeId = "4";
            paper.RewardClassId = "2";
            paper.WordCount = 4000;
            paper.AutherCount = 3;
            paper.AutherOrder = 2;
            return true;
        }

        /// <summary>
        /// 更新论文信息
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdatePaper(Paper paper, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除指定id的论文
        /// </summary>
        /// <param name="idList">ID列表</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeletePapersByIds(List<string> idList, ref string exception)
        {
            return true;
        }
        #endregion Paper

        #region Topic
        /// <summary>
        /// 根据路径导入Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="createCount">新增数量</param>
        /// <param name="updateCount">更新数量</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportTopicExcel(string path, ref int createCount, ref int updateCount, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取所有课题信息
        /// </summary>
        /// <param name="table">(ID, Depart, Office, Name, TopicName, TopicGrade, StartTime, StopTime, RewardGrade, RewardClass, CompleteType, WordCount, AutherCount, Auther1, Auther2, Auther3, Auther4, Auther5)</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllTopicInformation(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据搜索条件获取课题信息
        /// </summary>
        /// <param name="table">(ID, Depart, Office, Name, TopicName, TopicGrade, StartTime, StopTime, RewardGrade, RewardClass, CompleteType, WordCount, AutherCount, Auther1, Auther2, Auther3, Auther4, Auther5)</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetTopicInformationByCondition(ref DataTable table, SearchCondition searchCondition, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据记录ID获取课题信息
        /// </summary>
        /// <param name="topic">课题信息</param>
        /// <param name="id">记录ID</param>
        /// <param name="exception"></param>
        /// <returns>获取成功返回true，否则返回false</returns>
        public static bool GetTopicById(ref Topic topic, string id, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新课题信息
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateTopic(Topic topic, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除指定id的课题
        /// </summary>
        /// <param name="idList">ID列表</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteTopicsByIds(List<string> idList, ref string exception)
        {
            return true;
        }
        #endregion Topic

        #region Book
        /// <summary>
        /// 根据路径导入著作Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="createCount">新增数量</param>
        /// <param name="updateCount">更新数量</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportBookExcel(string path, ref int createCount, ref int updateCount, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取所有著作信息
        /// </summary>
        /// <param name="table">(ID, Depart, Office, Name, BookName, Press, PublishDate, PublishGrade, RewardGrade, RewardClass, WordCount, AutherCount, Auther1, Auther2, Auther3, Auther4, Auther5)</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllBookInformation(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据搜索条件获取著作信息
        /// </summary>
        /// <param name="table">查询结果</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetBookInformationByCondition(ref DataTable table, SearchCondition searchCondition, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据记录ID获取著作信息
        /// </summary>
        /// <param name="book">著作信息</param>
        /// <param name="id">记录ID</param>
        /// <param name="exception"></param>
        /// <returns>获取成功返回true，否则返回false</returns>
        public static bool GetBookById(ref Book book, string id, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新著作信息
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateBook(Book book, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除指定id的著作
        /// </summary>
        /// <param name="idList">ID列表</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteBooksByIds(List<string> idList, ref string exception)
        {
            return true;
        }
        #endregion

        #region Staff
        /// <summary>
        /// 根据路径导入人员Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportStaffExcel(string path, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取所有人员信息
        /// </summary>
        /// <param name="departStaffInformationList">查询结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllStaffInformation(ref List<DepartStaffInformation>  departStaffInformationList, ref string exception)
        {
            return true;
        }
        #endregion

        #region Common

        #endregion
    }
}
