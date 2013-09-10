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
        /// <param name="table">查询结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllPaperInformation(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据搜索条件获取文论信息
        /// </summary>
        /// <param name="table">查询结果</param>
        /// <param name="searchCondition">搜索条件</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetPaperInformationByCondition(ref DataTable table, SearchCondition searchCondition, ref string exception)
        {
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

        /// <summary>
        /// 获取论文发表级别的名称ID字典
        /// </summary>
        /// <param name="nameIdDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetPublishGradeNameIdDicForPaper(ref Dictionary<string, string> nameIdDic, ref string exception)
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
        /// <param name="table">查询结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllTopicInformation(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据搜索条件获取课题信息
        /// </summary>
        /// <param name="table">查询结果</param>
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

        /// <summary>
        /// 获取课题级别的名称ID字典
        /// </summary>
        /// <param name="nameIdDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetTopicGradeNameIdDicForTopic(ref Dictionary<string, string> nameIdDic, ref string exception)
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
        /// <param name="table">查询结果</param>
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

        /// <summary>
        /// 获取著作发行级别的名称ID字典
        /// </summary>
        /// <param name="nameIdDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetPublishGradeNameIdDicForBook(ref Dictionary<string, string> nameIdDic, ref string exception)
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
        /// <param name="departStaffInformation">查询结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetAllStaffInformation(ref DepartStaffInformation departStaffInformation, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部系和处室获取人员信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="departId">部系ID</param>
        /// <param name="officeId">处室ID（为空时表示该部系下的所有处室）</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        //public static bool GetStaffInformationByDepartAndOffice(ref DataTable table, string departId, string officeId, ref string exception)
        //{
        //    return true;
        //}
        #endregion

        #region Common
        /// <summary>
        /// 获取奖励级别级别的名称ID字典
        /// </summary>
        /// <param name="nameIdDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetRewardGradeNameIdDic(ref Dictionary<string, string> nameIdDic, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取奖励等级的名称ID字典
        /// </summary>
        /// <param name="nameIdDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetRewardClassNameIdDic(ref Dictionary<string, string> nameIdDic, ref string exception)
        {
            return true;
        }
        #endregion
    }
}
