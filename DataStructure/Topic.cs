using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    public class Topic
    {
        #region Private Field
        private string id;
        private string departId;
        private string officeId;
        private string name;
        private string topicName;
        private string topicGradeId;
        private string startTime;
        private string stopTime;
        private string rewardGradeId;
        private string rewardClassId;
        private string completeType;
        private string wordCount;
        private string autherCount;
        private string auther1;
        private string auther2;
        private string auther3;
        private string auther4;
        private string auther5;
        #endregion

        #region Public Field
        /// <summary>
        /// ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 部系单位ID
        /// </summary>
        public string DepartId
        {
            get { return departId; }
            set { departId = value; }
        }

        /// <summary>
        /// 处室单位ID
        /// </summary>
        public string OfficeId
        {
            get { return officeId; }
            set { officeId = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 课题名称
        /// </summary>
        public string TopicName
        {
            get { return topicName; }
            set { topicName = value; }
        }

        /// <summary>
        /// 课题级别ID
        /// </summary>
        public string TopicGradeId
        {
            get { return topicGradeId; }
            set { topicGradeId = value; }
        }

        /// <summary>
        /// 立项时间（年月）
        /// </summary>
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        /// <summary>
        /// 结题时间（年月）
        /// </summary>
        public string StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }

        /// <summary>
        /// 奖励级别ID
        /// </summary>
        public string RewardGradeId
        {
            get { return rewardGradeId; }
            set { rewardGradeId = value; }
        }

        /// <summary>
        /// 奖励等级ID
        /// </summary>
        public string RewardClassId
        {
            get { return rewardClassId; }
            set { rewardClassId = value; }
        }

        /// <summary>
        /// 完成形式
        /// </summary>
        public string CompleteType
        {
            get { return completeType; }
            set { completeType = value; }
        }

        /// <summary>
        /// 字数
        /// </summary>
        public string WordCount
        {
            get { return wordCount; }
            set { wordCount = value; }
        }

        /// <summary>
        /// 参与人数
        /// </summary>
        public string AutherCount
        {
            get { return autherCount; }
            set { autherCount = value; }
        }

        /// <summary>
        /// 参与人1
        /// </summary>
        public string Auther1
        {
            get { return auther1; }
            set { auther1 = value; }
        }

        /// <summary>
        /// 参与人2
        /// </summary>
        public string Auther2
        {
            get { return auther2; }
            set { auther2 = value; }
        }

        /// <summary>
        /// 参与人3
        /// </summary>
        public string Auther3
        {
            get { return auther3; }
            set { auther3 = value; }
        }

        /// <summary>
        /// 参与人4
        /// </summary>
        public string Auther4
        {
            get { return auther4; }
            set { auther4 = value; }
        }

        /// <summary>
        /// 5人以上（含）
        /// </summary>
        public string Auther5
        {
            get { return auther5; }
            set { auther5 = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 课题构造函数
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="departId">部系ID</param>
        /// <param name="officeId">处室ID</param>
        /// <param name="name">姓名</param>
        /// <param name="topicName">课题名称</param>
        /// <param name="topicGradeId">课题级别ID</param>
        /// <param name="startTime">立项时间（年月）</param>
        /// <param name="stopTime">结题时间（年月）</param>
        /// <param name="rewardGradeId">奖励级别ID</param>
        /// <param name="rewardClassId">奖励等级ID</param>
        /// <param name="completeType">完成形式</param>
        /// <param name="wordCount">字数</param>
        /// <param name="autherCount">参与人数</param>
        /// <param name="auther1">参与人1</param>
        /// <param name="auther2">参与人2</param>
        /// <param name="auther3">参与人3</param>
        /// <param name="auther4">参与人4</param>
        /// <param name="auther5">5人以上（含）</param>
        public Topic(string id, string departId, string officeId, string name, string topicName, string topicGradeId, string startTime, string stopTime, string rewardGradeId, string rewardClassId, string completeType, string wordCount, string autherCount, string auther1, string auther2, string auther3, string auther4, string auther5)
        {
            this.Id = id;
            this.DepartId = departId;
            this.OfficeId = officeId;
            this.Name = name;
            this.TopicName = topicName;
            this.TopicGradeId = topicGradeId;
            this.StartTime = startTime;
            this.StopTime = stopTime;
            this.RewardGradeId = rewardGradeId;
            this.RewardClassId = rewardClassId;
            this.CompleteType = completeType;
            this.WordCount = wordCount;
            this.AutherCount = autherCount;
            this.Auther1 = auther1;
            this.Auther2 = auther2;
            this.Auther3 = auther3;
            this.Auther4 = auther4;
            this.Auther5 = auther5;
        }
        #endregion
    }
}
