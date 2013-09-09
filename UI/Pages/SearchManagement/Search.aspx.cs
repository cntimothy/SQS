using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.Controller;
using FineUI;
using SQS.DataStructure;

namespace SQS.UI.Pages.SearchManagement
{
    public partial class Search : System.Web.UI.Page
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }
        #endregion

        #region Event
        #endregion

        #region Private Method
        private void bindPaperInformationToGrid()
        {

        }
        #endregion
    }
}