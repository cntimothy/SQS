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
        private int wordCount;
        private int autherCount;
        private int autherOrder;
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
        public int WordCount
        {
            get { return wordCount; }
            set { wordCount = value; }
        }

        /// <summary>
        /// 参与人数
        /// </summary>
        public int AutherCount
        {
            get { return autherCount; }
            set { autherCount = value; }
        }

        /// <summary>
        /// 第几作者
        /// </summary>
        public int AutherOrder
        {
            get { return autherOrder; }
            set { autherOrder = value; }
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
        public Topic(string id, string departId, string officeId, string name, string topicName, string topicGradeId, string startTime, string stopTime, string rewardGradeId, string rewardClassId, string completeType, int wordCount, int autherCount, int autherOrder)
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
            this.AutherOrder = autherOrder;
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Topic()
        { }
        #endregion
    }
}
