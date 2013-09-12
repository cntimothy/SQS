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
    public partial class iframe_AddOffice : PageBase
    {
        #region Page Init
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
        protected void Button_AddNew_Click(object sender, EventArgs e)
        {
            if (TextBox_OfficeName.Text.Trim() == "")
            {
                Alert.ShowInTop("请输入新处室名称！", MessageBoxIcon.Warning);
                return;
            }
            string newName = TextBox_OfficeName.Text.Trim();
            string departId = DropDownList_Depart.SelectedValue;
            string exception = "";
            if (BasicInformationManagementCtrl.AddNewOffice(departId, newName, ref exception))
            {
                Alert.ShowInTop("新增成功！", MessageBoxIcon.Information);
                PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
            }
            else
            {
                Alert.ShowInTop("新增失败！\n原因：" + exception, MessageBoxIcon.Error);
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