using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.Controller
{
    public class CommonCtrl
    {
        /// <summary>
        /// 获取所有部系名称ID字典
        /// </summary>
        /// <param name="nameIdDic">部系名称ID字典</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetDepartNameIdDic(ref Dictionary<string, string> nameIdDic, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部系ID获取该部系下处室名称ID字典
        /// </summary>
        /// <param name="nameIdDic">处室名称ID字典</param>
        /// <param name="departId">部系ID</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetOfficeNameIdDicByDepartId(ref Dictionary<string, string> nameIdDic, string departId, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取有记录年份到今年的年份列表
        /// </summary>
        /// <param name="yearList">年份列表</param>
        /// <param name="exception"></param>
        /// <returns>获取非空列表返回true，否则返回false<</returns>
        public static bool GetYearList(ref List<string> yearList, ref string exception)
        {
            int curYear = DateTime.Now.Year;
            for (int year = 1999; year <= curYear; year++)
            {
                yearList.Add(year.ToString());
            }
            return true;
        }
    }
}
