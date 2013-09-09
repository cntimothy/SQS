using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    #region class IndividualScore
    public class IndividualScore
    {
        #region private Field
        private string name;        
        private float paperScore;
        private float bookScore;
        private float topicScore;
        private float totalScore;
        #endregion

        #region public Field
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 论文得分
        /// </summary>
        public float PaperScore
        {
            get { return paperScore; }
            set { paperScore = value; }
        }

        /// <summary>
        /// 著作得分
        /// </summary>
        public float BookScore
        {
            get { return bookScore; }
            set { bookScore = value; }
        }

        /// <summary>
        /// 课题得分
        /// </summary>
        public float TopicScore
        {
            get { return topicScore; }
            set { topicScore = value; }
        }

        /// <summary>
        /// 总分
        /// </summary>
        public float TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="paperScore">论文得分</param>
        /// <param name="bookScore">著作得分</param>
        /// <param name="topicScore">课题得分</param>
        /// <param name="totalScore">总分</param>
        public IndividualScore(string name, float paperScore, float bookScore, float topicScore, float totalScore)
        {
            this.Name = name;
            this.PaperScore = paperScore;
            this.BookScore = BookScore;
            this.TopicScore = topicScore;
            this.TotalScore = totalScore;
        }
        #endregion
    }
    #endregion

    #region calss OfficeScore
    public class OfficeScore
    {
        #region private Field
        private string officeName;
        private List<IndividualScore> staff;
        private float paperTotalScore;
        private float bookTotalScore;
        private float topicTotalScore;
        private float totalScore;
        private float averageScore;
        private float participateRate;
        #endregion

        #region public Field
        /// <summary>
        /// 处室名称
        /// </summary>
        public string OfficeName
        {
            get { return officeName; }
            set { officeName = value; }
        }

        /// <summary>
        /// 人员列表
        /// </summary>
        public List<IndividualScore> Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        /// <summary>
        /// 处室论文总分
        /// </summary>
        public float PaperTotalScore
        {
            get { return paperTotalScore; }
            set { paperTotalScore = value; }
        }

        /// <summary>
        /// 处室著作总分
        /// </summary>
        public float BookTotalScore
        {
            get { return bookTotalScore; }
            set { bookTotalScore = value; }
        }

        /// <summary>
        /// 处室课题总分
        /// </summary>
        public float TopicTotalScore
        {
            get { return topicTotalScore; }
            set { topicTotalScore = value; }
        }

        /// <summary>
        /// 处室总分
        /// </summary>
        public float TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        /// <summary>
        /// 处室人均成绩
        /// </summary>
        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }

        /// <summary>
        /// 处室参研率
        /// </summary>
        public float ParticipateRate
        {
            get { return participateRate; }
            set { participateRate = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 处室构造函数
        /// </summary>
        /// <param name="officeName">处室名称</param>
        /// <param name="paperTotalScore">处室论文总分</param>
        /// <param name="bookTotalScore">处室著作总分</param>
        /// <param name="topicTotalScore">处室课题总分</param>
        /// <param name="totalScore">处室总分</param>
        /// <param name="averageScore">处室人均成绩</param>
        /// <param name="participateRate">处室参研率</param>
        public OfficeScore(string officeName, float paperTotalScore, float bookTotalScore, float topicTotalScore, float totalScore, float averageScore, float participateRate)
        {
            this.OfficeName = officeName;
            this.PaperTotalScore = paperTotalScore;
            this.BookTotalScore = bookTotalScore;
            this.TopicTotalScore = topicTotalScore;
            this.TotalScore = totalScore;
            this.AverageScore = averageScore;
            this.ParticipateRate = participateRate;

            this.Staff = new List<IndividualScore>();
        }
        #endregion
    }
    #endregion

    #region class DepartScore
    public class DepartScore
    {
        #region private Field
        private string departName;
        private List<OfficeScore> officeList;
        private float totalScore;
        private float paperAverageScore;
        private float averageScore;
        #endregion

        #region public Field
        /// <summary>
        /// 部系名称
        /// </summary>
        public string DepartName
        {
            get { return departName; }
            set { departName = value; }
        }

        /// <summary>
        /// 处室列表
        /// </summary>
        public List<OfficeScore> OfficeList
        {
            get { return officeList; }
            set { officeList = value; }
        }

        /// <summary>
        /// 部系总成绩
        /// </summary>
        public float TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        /// <summary>
        /// 部系论文人均分
        /// </summary>
        public float PaperAverageScore
        {
            get { return paperAverageScore; }
            set { paperAverageScore = value; }
        }

        /// <summary>
        /// 部系人均分
        /// </summary>
        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 部系构造函数
        /// </summary>
        /// <param name="departName">部系名称</param>
        /// <param name="totalScore">部系总成绩</param>
        /// <param name="paperAverageScore">部系论文人均分</param>
        /// <param name="averageScore">部系人均分</param>
        public DepartScore(string departName, float totalScore, float paperAverageScore, float averageScore)
        {
            this.DepartName = departName;
            this.TotalScore = totalScore;
            this.PaperAverageScore = paperAverageScore;
            this.AverageScore = averageScore;

            this.OfficeList = new List<OfficeScore>();
        }
        #endregion
    }
    #endregion
}
