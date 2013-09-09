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
        /// 发表日期（起）
        /// </summary>
        public string PublishDateStart
        {
            get { return publishDateStart; }
            set { publishDateStart = value; }
        }

        /// <summary>
        /// 发表日期（止）
        /// </summary>
        public string PublishDateStop
        {
            get { return publishDateStop; }
            set { publishDateStop = value; }
        }

        /// <summary>
        /// 创建日期（起）
        /// </summary>
        public string CreateDateStart
        {
            get { return createDateStart; }
            set { createDateStart = value; }
        }

        /// <summary>
        /// 创建日期（止）
        /// </summary>
        public string CreateDateStop
        {
            get { return createDateStop; }
            set { createDateStop = value; }
        }

        /// <summary>
        /// 更新日期（起）
        /// </summary>
        public string UpdateDateStart
        {
            get { return updateDateStart; }
            set { updateDateStart = value; }
        }

        /// <summary>
        /// 更新日期（止）
        /// </summary>
        public string UpdateDateStop
        {
            get { return updateDateStop; }
            set { updateDateStop = value; }
        }
        #endregion

        #region Constructor
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
