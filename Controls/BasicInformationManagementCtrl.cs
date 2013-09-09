using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SQS.Controller
{
    public class BasicInformationManagementCtrl
    {
        /// <summary>
        /// 获取所有部系处室信息table
        /// </summary>
        /// <param name="table">获取的信息</param>
        /// <param name="exception"></param>
        /// <returns>获取成功且非空返回true，否则返回false</returns>
        public static bool GetAllDepartOffice(ref DataTable table, ref string exception)
        {
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
        /// <param name="officeId">处室id</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteOffice(string officeId, ref string exception)
        {
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
