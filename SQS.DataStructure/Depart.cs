using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    public class Office
    {
        #region Private Field
        private string name;
        #endregion

        #region Public Field
        /// <summary>
        /// 处室名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 处室构造函数
        /// </summary>
        /// <param name="name">处室名称</param>
        public Office(string name)
        {
            this.Name = name;
        }
        #endregion
    }

    /// <summary>
    /// 用于部门处室管理
    /// </summary>
    public class Depart
    {
        #region Private Field
        private string name;
        private List<Office> offices;
        #endregion

        #region Public Field
        /// <summary>
        /// 部系名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 下属处室列表
        /// </summary>
        public List<Office> Offices
        {
            get { return offices; }
            set { offices = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 处室构造函数
        /// </summary>
        /// <param name="name">处室名称</param>
        public Depart(string name)
        {
            this.Name = name;
            this.Offices = new List<Office>();
        }
        #endregion
    }
}
