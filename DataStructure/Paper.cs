using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    public class Paper
    {
        #region Private Field
        private string id;
        private string departId;
        private string officeId;
        private string name;
        private string paperName;
        private string journalName;
        private string publishDate;
        private string publishGradeId;
        private string rewardGradeId;
        private string rewardClassId;
        private string wordCount;
        private string autherCount;
        private string auther1;
        private string auther2;
        private string auther3;
        #endregion

        #region Public Field
        /// <summary>
        /// 记录ID
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
        /// 论文名称
        /// </summary>
        public string PaperName
        {
            get { return paperName; }
            set { paperName = value; }
        }

        /// <summary>
        /// 发表刊物、会议或文集名称
        /// </summary>
        public string JournalName
        {
            get { return journalName; }
            set { journalName = value; }
        }

        /// <summary>
        /// 发表时间（年月）
        /// </summary>
        public string PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }

        /// <summary>
        /// 发表级别ID
        /// </summary>
        public string PublishGradeId
        {
            get { return publishGradeId; }
            set { publishGradeId = value; }
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
        /// 字数
        /// </summary>
        public string WordCount
        {
            get { return wordCount; }
            set { wordCount = value; }
        }

        /// <summary>
        /// 作者人数
        /// </summary>
        public string AutherCount
        {
            get { return autherCount; }
            set { autherCount = value; }
        }

        /// <summary>
        /// 第1作者
        /// </summary>
        public string Auther1
        {
            get { return auther1; }
            set { auther1 = value; }
        }

        /// <summary>
        /// 第2作者
        /// </summary>
        public string Auther2
        {
            get { return auther2; }
            set { auther2 = value; }
        }

        /// <summary>
        /// 第3作者
        /// </summary>
        public string Auther3
        {
            get { return auther3; }
            set { auther3 = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 论文构造函数
        /// </summary>
        /// <param name="id">记录ID</param>
        /// <param name="departId">DepartID</param>
        /// <param name="officeId">处室单位ID</param>
        /// <param name="name">姓名</param>
        /// <param name="paperName">论文名称</param>
        /// <param name="journalName">发表刊物、会议或文集名称</param>
        /// <param name="publishDate">发表时间（年月）</param>
        /// <param name="publishGradeId">发表级别</param>
        /// <param name="rewardGradeId">奖励级别</param>
        /// <param name="rewardClassId">奖励等级</param>
        /// <param name="wordCount">字数</param>
        /// <param name="autherCount">作者人数</param>
        /// <param name="auther1">第1作者</param>
        /// <param name="auther2">第2作者</param>
        /// <param name="auther3">第3作者</param>
        public Paper(string id, string departId, string officeId, string name, string paperName, string journalName, string publishDate, string publishGradeId, string rewardGradeId, string rewardClassId, string wordCount, string autherCount, string auther1, string auther2, string auther3)
        {
            this.Id = id;
            this.DepartId = departId;
            this.OfficeId = OfficeId;
            this.Name = name;
            this.PaperName = paperName;
            this.JournalName = journalName;
            this.PublishDate = publishDate;
            this.PublishGradeId = publishGradeId;
            this.RewardGradeId = rewardGradeId;
            this.RewardClassId = rewardClassId;
            this.WordCount = wordCount;
            this.AutherCount = autherCount;
            this.Auther1 = auther1;
            this.Auther2 = auther2;
            this.Auther3 = auther3;
        }
        #endregion
    }
}
