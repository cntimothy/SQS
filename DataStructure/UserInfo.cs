using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    public class UserInfo
    {
        #region Private Field
        string id;
        string name;
        AccessLevel accessLevel;
        string depart;
        #endregion

        #region Public Field
        /// <summary>
        /// 用户名
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
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
        /// 权限等级
        /// </summary>
        public AccessLevel AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }

        /// <summary>
        /// 部门
        /// </summary>
        public string Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        #endregion
    }
}
