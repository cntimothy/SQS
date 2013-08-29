using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SQS.Controller
{
    public class InputManagementCtrl
    {
        #region Paper
        /// <summary>
        /// 根据路径导入论文Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportPaperExcel(string path, ref string exception)
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
        /// 根据部系获取论文信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetPaperInformationByDepart(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部系和处室获取论文信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetPaperInformationByDepartAndOffice(ref DataTable table, ref string exception)
        {
            return true;
        }
        #endregion Paper

        #region Topic
        /// <summary>
        /// 根据路径导入课题Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportTopicExcel(string path, ref string exception)
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
        /// 根据部系获取课题信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetTopicInformationByDepart(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部系和处室获取课题信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetTopicInformationByDepartAndOffice(ref DataTable table, ref string exception)
        {
            return true;
        }
        #endregion Topic

        #region Book
        /// <summary>
        /// 根据路径导入论文Excel
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <param name="exception"></param>
        /// <returns>导入成功返回true，否则返回false</returns>
        public static bool InportBookExcel(string path, ref string exception)
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
        /// 根据部系获取著作信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetBookInformationByDepart(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部系和处室获取著作信息
        /// </summary>
        /// <param name="table">查询的结果</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且结果不为空返回true，否则返回false</returns>
        public static bool GetBookInformationByDepartAndOffice(ref DataTable table, ref string exception)
        {
            return true;
        }
        #endregion
    }
}
