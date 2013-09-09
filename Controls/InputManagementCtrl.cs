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
    }
}
