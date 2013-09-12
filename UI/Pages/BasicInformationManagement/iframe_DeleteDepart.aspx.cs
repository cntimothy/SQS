using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.Controller;

namespace SQS.UI.Pages.BasicInformationManagement
{
    public partial class iframe_DeleteDepart : System.Web.UI.Page
    {
        #region PageInit
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDepartToDropDownList();
                Button_Cancel.OnClientClick = ActiveWindow.GetHideReference();
            }
        }
        #endregion

        #region Event
        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            string exception = "";
            string id = DropDownList_Depart.SelectedValue;
            if (BasicInformationManagementCtrl.DeleteDepart(id, ref exception))
            {
                Alert.ShowInTop("删除成功！", MessageBoxIcon.Information);
                PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
            }
            else
            {
                Alert.ShowInTop("删除失败！\n原因：" + exception, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region Private Method
        private void bindDepartToDropDownList()
        {
            DropDownList_Depart.Items.Clear();
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            if (CommonCtrl.GetDepartIdNameDic(ref idNameDic, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_Depart.Items.Add(idNameDic[id], id);
                }
            }
        }
        #endregion
    }
}