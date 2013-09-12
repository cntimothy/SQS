using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SQS.DataStructure;

namespace SQS.Controller
{
    public class BasicInformationManagementCtrl
    {
        /// <summary>
        /// 获取所有部系处室信息
        /// </summary>
        /// <param name="departList"></param>
        /// <param name="exception"></param>
        /// <returns>获取成功且非空返回true，否则返回false</returns>
        public static bool GetAllDepartOffice(ref List<Depart> departList, ref string exception)
        {
            Office office1 = new Office("政治理论系系部");
            Office office2 = new Office("学员1队");
            Office office3 = new Office("学员2队");
            Office office4 = new Office("学员3队");
            Office office5 = new Office("哲学教研室");
            Office office6 = new Office("经济学教研室");
            Office office7 = new Office("历史学教研室");
            Depart depart1 = new Depart("政治理论系");
            depart1.Offices.Add(office1);
            depart1.Offices.Add(office2);
            depart1.Offices.Add(office3);
            depart1.Offices.Add(office4);
            depart1.Offices.Add(office5);
            depart1.Offices.Add(office6);
            depart1.Offices.Add(office7);

            Office office8 = new Office("党建工作系部");
            Office office9 = new Office("学员4队");
            Office office10 = new Office("学员5队");
            Office office11 = new Office("学员6队");
            Office office12 = new Office("学员7队");
            Office office13 = new Office("党的建设教研室");
            Office office14 = new Office("军队党的建设教研室");
            Office office15 = new Office("党史教研室");
            Office office16 = new Office("军队党委教研室");
            Office office17 = new Office("纪律检查教研室");
            Depart depart2 = new Depart("党建工作系");
            depart2.Offices.Add(office8);
            depart2.Offices.Add(office9);
            depart2.Offices.Add(office10);
            depart2.Offices.Add(office11);
            depart2.Offices.Add(office12);
            depart2.Offices.Add(office13);
            depart2.Offices.Add(office14);
            depart2.Offices.Add(office15);
            depart2.Offices.Add(office16);
            depart2.Offices.Add(office17);

            departList.Add(depart1);
            departList.Add(depart2);
            return true;
        }

        /// <summary>
        /// 删除指定id的部系
        /// </summary>
        /// <param name="departId">部系id</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteDepart(string departId, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除指定id的处室
        /// </summary>
        /// <param name="departId">部系id</param>
        /// <param name="officeId">处室id</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteOffice(string departId, string officeId, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 新增部系
        /// </summary>
        /// <param name="newDepartName">新部系名称</param>
        /// <param name="exception"></param>
        /// <returns>新增成功返回true，否则返回false</returns>
        public static bool AddNewDepart(string newDepartName, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 新增处室
        /// </summary>
        /// <param name="departId">部系id</param>
        /// <param name="newOfficeName">新处室名称</param>
        /// <param name="exception"></param>
        /// <returns>新增成功返回true，否则返回false</returns>
        public static bool AddNewOffice(string departId, string newOfficeName, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取著作发行级别
        /// </summary>
        /// <param name="table">(ID, Name)</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetPublishGradeForBook(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Rows.Add("1", "正式出版专著");
            table.Rows.Add("2", "正式出版（编、译著，工具书）");
            table.Rows.Add("3", "内部印刷");
            return true;
        }

        /// <summary>
        /// 获取论文发表级别
        /// </summary>
        /// <param name="table">(ID, Name)</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetPublishGradeForPaper(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Rows.Add("1", "指定报刊");
            table.Rows.Add("2", "核心报刊");
            table.Rows.Add("3", "普通报刊");
            table.Rows.Add("4", "内部期刊");
            return true;
        }

        /// <summary>
        /// 获取课题级别
        /// </summary>
        /// <param name="table">(ID, Name)</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetTopicGrade(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Rows.Add("1", "国家课题");
            table.Rows.Add("2", "全军课题");
            table.Rows.Add("3", "总部课题");
            table.Rows.Add("4", "院校课题");
            return true;
        }

        /// <summary>
        /// 获取奖励级别
        /// </summary>
        /// <param name="table">(ID, Name)</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetRewardGrade(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Rows.Add("1", "国家级");
            table.Rows.Add("2", "全军级");
            table.Rows.Add("3", "总部级");
            return true;
        }

        /// <summary>
        /// 获取奖励等级
        /// </summary>
        /// <param name="table">(ID, Name)</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetRewardClass(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Rows.Add("1", "一等奖");
            table.Rows.Add("2", "二等奖");
            table.Rows.Add("3", "三等奖");
            return true;
        }

        /// <summary>
        /// 更新著作发行级别名称
        /// </summary>
        /// <param name="bookPublishGradeId">著作发行级别id</param>
        /// <param name="newPublishGradeName">著作发行级别新名称</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdatePublishGradeNameForBook(string bookPublishGradeId, string newPublishGradeName, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新论文发表级别名称
        /// </summary>
        /// <param name="paperPublishGradeId">论文发表级别id</param>
        /// <param name="newPublishGradeName">论文发表级别新名称</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdatePublishGradeNameForPaper(string paperPublishGradeId, string newPublishGradeName, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新课题级别名称
        /// </summary>
        /// <param name="topicPublishGradeId">课题级别id</param>
        /// <param name="newPublishGradeName">课题级别新名称</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateTopicGradeNameForTopic(string topicPublishGradeId, string newPublishGradeName, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新奖励级别名称
        /// </summary>
        /// <param name="rewardGradeId">奖励级别id</param>
        /// <param name="newRewardGradeName">奖励级别新名称</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateRewardGradeName(string rewardGradeId, string newRewardGradeName, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新奖励等级名称
        /// </summary>
        /// <param name="rewardClassId">奖励等级id</param>
        /// <param name="newRewardClassName">奖励等级新名称</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateRewardClassName(string rewardClassId, string newRewardClassName, ref string exception)
        {
            return true;
        }
    }
}
