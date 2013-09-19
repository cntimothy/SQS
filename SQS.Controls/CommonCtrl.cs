using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.Controller
{
    public class CommonCtrl
    {
        /// <summary>
        /// 获取所有部系ID名称字典
        /// </summary>
        /// <param name="idNameDic">部系ID名称字典</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetDepartIdNameDic(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("1", "政治理论系");
            idNameDic.Add("2", "党建工作系");
            idNameDic.Add("3", "基层政治工作系");
            idNameDic.Add("4", "政治机关工作系");
            idNameDic.Add("5", "军事安全保卫系");
            idNameDic.Add("6", "军事心理学系");
            idNameDic.Add("7", "训练部");
            idNameDic.Add("8", "政治部");
            return true;
        }

        /// <summary>
        /// 根据部系ID获取该部系下处室ID名称字典
        /// </summary>
        /// <param name="idNameDic">处室ID名称字典</param>
        /// <param name="departId">部系ID</param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetOfficeIdNameDicByDepartId(ref Dictionary<string, string> idNameDic, string departId, ref string exception)
        {
            idNameDic.Add("1", "政治理论系系部");
            idNameDic.Add("2", "学员1队");
            idNameDic.Add("3", "学员2队");
            idNameDic.Add("4", "学员3队");
            idNameDic.Add("5", "哲学教研室");
            return true;
        }

        /// <summary>
        /// 获取论文发表级别的ID名称字典
        /// </summary>
        /// <param name="idNameDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetPublishGradeIdNameDicForPaper(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("1", "指定报刊");
            idNameDic.Add("2", "核心报刊");
            idNameDic.Add("3", "普通报刊");
            idNameDic.Add("4", "内部期刊");
            return true;
        }

        /// <summary>
        /// 获取课题级别的ID名称字典
        /// </summary>
        /// <param name="idNameDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetTopicGradeIdNameDic(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("1", "国家课题");
            idNameDic.Add("2", "全军课题");
            idNameDic.Add("3", "总部课题");
            idNameDic.Add("4", "院校课题");
            return true;
        }

        /// <summary>
        /// 获取著作发行级别的ID名称字典
        /// </summary>
        /// <param name="idNameDic"></param>
        /// <param name="exception"></param>
        /// <returns>查询成功且非空返回true，否则返回false</returns>
        public static bool GetPublishGradeIdNameDicForBook(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("1", "正式出版专著");
            idNameDic.Add("2", "正式出版（编、译著，工具书）");
            idNameDic.Add("3", "内部印刷");
            return true;
        }

        /// <summary>
        /// 获取获奖级别ID名称字典
        /// </summary>
        /// <param name="idNameDic"></param>
        /// <param name="exception"></param>
        /// <returns>获取成功且非空返回true，否则返回false</returns>
        public static bool GetRewardGradeIdNameDic(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("1", "国家级");
            idNameDic.Add("2", "全军级");
            idNameDic.Add("3", "总部级");
            return true;
        }

        /// <summary>
        /// 获取获奖等级ID名称字典
        /// </summary>
        /// <param name="idNameDic"></param>
        /// <param name="exception"></param>
        /// <returns>获取成功且非空返回true，否则返回false</returns>
        public static bool GetRewardClassIdNameDic(ref Dictionary<string, string> idNameDic, ref string exception)
        {
            idNameDic.Add("1", "一等奖");
            idNameDic.Add("2", "二等奖");
            idNameDic.Add("3", "三等奖");
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
