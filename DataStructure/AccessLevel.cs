using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQS.DataStructure
{
    /// <summary>
    /// 权限等级
    /// </summary>
    public enum AccessLevel
    {
        evaluator,          //被考评人
        secondManager,      //系级管理员
        firstManager,       //人事处管理员
        superManager        //超级管理员
    }
}
