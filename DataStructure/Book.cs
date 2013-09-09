using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.Controller
{
    public class Book
    {
        #region Private Field
        private string id;
        private string departId;
        private string officeId;
        private string name;
        private string bookName;
        private string press;
        private string publishDate;
        private string publishGradeId;
        private string rewardGradeId;
        private string rewardClassId;
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
        /// 著作记录的ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 部系ID
        /// </summary>
        public string DepartId
        {
            get { return departId; }
            set { departId = value; }
        }

        /// <summary>
        /// 处室ID
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
        /// 著作名称
        /// </summary>
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        /// <summary>
        /// 出版社
        /// </summary>
        public string Press
        {
            get { return press; }
            set { press = value; }
        }

        /// <summary>
        /// 出版时间（年月）
        /// </summary>
        public string PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }

        /// <summary>
        /// 发行级别
        /// </summary>
        public string PublishGradeId
        {
            get { return publishGradeId; }
            set { publishGradeId = value; }
        }

        /// <summary>
        /// 奖励级别
        /// </summary>
        public string RewardGradeId
        {
            get { return rewardGradeId; }
            set { rewardGradeId = value; }
        }

        /// <summary>
        /// 奖励等级
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
        /// 编写人数
        /// </summary>
        public string AutherCount
        {
            get { return autherCount; }
            set { autherCount = value; }
        }

        /// <summary>
        /// 编1
        /// </summary>
        public string Auther1
        {
            get { return auther1; }
            set { auther1 = value; }
        }

        /// <summary>
        /// 编2
        /// </summary>
        public string Auther2
        {
            get { return auther2; }
            set { auther2 = value; }
        }

        /// <summary>
        /// 编3
        /// </summary>
        public string Auther3
        {
            get { return auther3; }
            set { auther3 = value; }
        }

        /// <summary>
        /// 编4
        /// </summary>
        public string Auther4
        {
            get { return auther4; }
            set { auther4 = value; }
        }

        /// <summary>
        /// 编5以上（含）
        /// </summary>
        public string Auther5
        {
            get { return auther5; }
            set { auther5 = value; }
        }
        #endregion

        #region Constructor
        public Book(string id, string departId, string officeId, string name, string bookName, string press, string publishDate, string publishGradeId, string rewardGradeId, string rewardClassId, string wordCount, string autherCount, string auther1, string auther2, string auther3, string auther4, string auther5)
        {
            this.Id = id;
            this.DepartId = departId;
            this.OfficeId = officeId;
            this.Name = name;
            this.BookName = bookName;
            this.Press = press;
            this.PublishDate = publishDate;
            this.PublishGradeId = publishGradeId;
            this.RewardGradeId = rewardGradeId;
            this.RewardClassId = rewardClassId;
            this.WordCount = wordCount; ;
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
