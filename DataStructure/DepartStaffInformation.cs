using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    public class OfficeStaffInformation
    {
        #region Private Field
        private string name;
        private int staffCount;
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

        /// <summary>
        /// 处室人数
        /// </summary>
        public int StaffCount
        {
            get { return staffCount; }
            set { staffCount = value; }
        }
        #endregion

        #region Constructor
        public OfficeStaffInformation(string name, int staffCount)
        {
            this.Name = name;
            this.StaffCount = staffCount;
        }
        #endregion
    }

    /// <summary>
    /// 用于人员信息
    /// </summary>
    public class DepartStaffInformation
    {
        #region Private Field
        private string name;
        private List<OfficeStaffInformation> offices;
        private int staffCount;
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
        /// 部系下的处室列表
        /// </summary>
        public List<OfficeStaffInformation> Offices
        {
            get { return offices; }
            set { offices = value; }
        }

        /// <summary>
        /// 部系总人数
        /// </summary>
        public int StaffCount
        {
            get { return staffCount; }
            set { staffCount = value; }
        }
        #endregion

        #region Constructor
        public DepartStaffInformation(string name)
        {
            this.Name = name;
            this.StaffCount = 0;

            this.offices = new List<OfficeStaffInformation>();
        }
        #endregion

        #region Public Methiod
        public void AddOffice(OfficeStaffInformation officeStaffInformation)
        {
            this.offices.Add(officeStaffInformation);
            this.StaffCount += officeStaffInformation.StaffCount;
        }
        #endregion
    }
}
