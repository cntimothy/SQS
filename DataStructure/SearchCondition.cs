using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    public class SearchCondition
    {
        #region Private Field
        private string name;
        private string workName;
        private string departId;
        private string officeId;
        private string publishDateStart;
        private string publishDateStop;
        private string createDateStart;
        private string createDateStop;
        private string updateDateStart;
        private string updateDateStop;
        #endregion

        #region Public Field
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 著作、论文、课题名称
        /// </summary>
        public string WorkName
        {
            get { return workName; }
            set { workName = value; }
        }

        /// <summary>
        /// 部系名称
        /// </summary>
        public string DepartId
        {
            get { return departId; }
            set { departId = value; }
        }

        /// <summary>
        /// 处室名称
        /// </summary>
        public string OfficeId
        {
            get { return officeId; }
            set { officeId = value; }
        }

        /// <summary>
        /// 发表、出版、结题日期（起）（年月）
        /// </summary>
        public string PublishDateStart
        {
            get { return publishDateStart; }
            set { publishDateStart = value; }
        }

        /// <summary>
        /// 发表、出版、结题日期（止）（年月）
        /// </summary>
        public string PublishDateStop
        {
            get { return publishDateStop; }
            set { publishDateStop = value; }
        }

        /// <summary>
        /// 创建日期（起）（年月日）
        /// </summary>
        public string CreateDateStart
        {
            get { return createDateStart; }
            set { createDateStart = value; }
        }

        /// <summary>
        /// 创建日期（止）（年月日）
        /// </summary>
        public string CreateDateStop
        {
            get { return createDateStop; }
            set { createDateStop = value; }
        }

        /// <summary>
        /// 更新日期（起）（年月日）
        /// </summary>
        public string UpdateDateStart
        {
            get { return updateDateStart; }
            set { updateDateStart = value; }
        }

        /// <summary>
        /// 更新日期（止）（年月日）
        /// </summary>
        public string UpdateDateStop
        {
            get { return updateDateStop; }
            set { updateDateStop = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="workName">著作、论文、课题名</param>
        /// <param name="departId">部系id</param>
        /// <param name="officeId">处室id</param>
        /// <param name="publishDateStart">发表、出版、结题日期（起）（年月）</param>
        /// <param name="publishDateStop">发表、出版、结题日期（止）（年月）</param>
        /// <param name="createDateStart">创建日期（起）（年月日）</param>
        /// <param name="createDateStop">创建日期（止）（年月日）</param>
        /// <param name="updateDateStart">更新日期（起）（年月日）</param>
        /// <param name="updateDateStop">更新日期（止）（年月日）</param>
        public SearchCondition(string name, string workName, string departId, string officeId, string publishDateStart, string publishDateStop, string createDateStart, string createDateStop, string updateDateStart, string updateDateStop)
        {
            this.Name = name;
            this.WorkName = name;
            this.DepartId = departId;
            this.OfficeId = officeId;
            this.PublishDateStart = publishDateStart;
            this.PublishDateStop = publishDateStop;
            this.CreateDateStart = createDateStart;
            this.CreateDateStop = createDateStop;
            this.UpdateDateStart = updateDateStart;
            this.UpdateDateStop = updateDateStop;
        }
        #endregion
    }
}
