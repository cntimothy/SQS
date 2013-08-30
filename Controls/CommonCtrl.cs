using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.Controller
{
    public class CommonCtrl
    {
        /// <summary>
        /// 获取部系列表
        /// </summary>
        /// <param name="departList">部系列表</param>
        /// <param name="exception"></param>
        /// <returns>获取非空列表返回true，否则返回false</returns>
        public static bool GetDepartList(ref List<string> departList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部系获取处室列表
        /// </summary>
        /// <param name="officeList">处室列表</param>
        /// <param name="exception"></param>
        /// <returns>获取非空列表返回true，否则返回false</returns>
        public static bool GetOfficeListByDepart(ref List<string> officeList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取从2013年以来的年份列表
        /// </summary>
        /// <param name="yearList">年份列表</param>
        /// <param name="exception"></param>
        /// <returns>获取非空列表返回true，否则返回false<</returns>
        public static bool GetYearList(ref List<string> yearList, ref string exception)
        {
            int curYear = DateTime.Now.Year;
            for (int year = 2013; year <= curYear; year++)
            {
                yearList.Add(year.ToString());
            }
            return true;
        }
    }
}
