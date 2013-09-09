using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.DataStructure;
using SQS.Controller;
using FineUI;

namespace SQS.UI.Pages.BasicInformationManagement
{
    public partial class OfficeManegement : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Event
        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
        }
        protected void Grid1_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            
        }
        #endregion

        #region Private Method

        #endregion
    }
}