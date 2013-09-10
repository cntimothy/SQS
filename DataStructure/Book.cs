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
        private int wordCount;
        private int autherCount;
        private int autherOrder;
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
        public int WordCount
        {
            get { return wordCount; }
            set { wordCount = value; }
        }

        /// <summary>
        /// 编写人数
        /// </summary>
        public int AutherCount
        {
            get { return autherCount; }
            set { autherCount = value; }
        }

        /// <summary>
        /// 第几编者
        /// </summary>
        public int AutherOrder
        {
            get { return autherOrder; }
            set { autherOrder = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">记录id</param>
        /// <param name="departId">部系id</param>
        /// <param name="officeId">处室id</param>
        /// <param name="name">姓名</param>
        /// <param name="bookName">著作名称</param>
        /// <param name="press">出版社</param>
        /// <param name="publishDate">出版日期</param>
        /// <param name="publishGradeId">出版级别id</param>
        /// <param name="rewardGradeId">获奖级别id</param>
        /// <param name="rewardClassId">获奖等级id</param>
        /// <param name="wordCount">字数</param>
        /// <param name="autherCount">作者人数</param>
        /// <param name="autherOrder">第几作者</param>
        public Book(string id, string departId, string officeId, string name, string bookName, string press, string publishDate, string publishGradeId, string rewardGradeId, string rewardClassId, int wordCount, int autherCount, int autherOrder)
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
            this.AutherOrder = autherOrder;
        }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Book()
        { }
        #endregion
    }
}
