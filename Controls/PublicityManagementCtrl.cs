using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.Controller
{
    public class PublicityManagementCtrl
    {
        /// <summary>
        /// 开始公示
        /// </summary>
        /// <param name="exception"></param>
        /// <returns>设置成功返回true，否则返回false</returns>
        public static bool StartPublicity(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 结束公示
        /// </summary>
        /// <param name="exception"></param>
        /// <returns>设置成功返回true，否则返回false</returns>
        public static bool StopPublicity(ref string exception)
        {
            return true;
        }
    }
}
