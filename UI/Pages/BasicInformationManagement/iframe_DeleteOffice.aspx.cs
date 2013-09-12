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
    public partial class iframe_DeleteOffice : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDepartToDropDownList();
                bindOfficeToDropDownList();
                Button_Cancel.OnClientClick = ActiveWindow.GetHideReference();
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// 部系下拉列表事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList_Depart_SelectedChanged(object sender, EventArgs e)
        {
            bindOfficeToDropDownList();
        }

        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            string departId = DropDownList_Depart.SelectedValue;
            string officeId = DropDownList_Office.SelectedValue;
            string exception = "";
            if (BasicInformationManagementCtrl.DeleteOffice(departId, officeId, ref exception))
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
        /// <summary>
        /// 绑定部系到下拉列表
        /// </summary>
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

        /// <summary>
        /// 绑定处室到下拉列表
        /// </summary>
        private void bindOfficeToDropDownList()
        {
            DropDownList_Office.Items.Clear(); //删除原来的项目

            string departId = DropDownList_Depart.SelectedValue;
            if (departId != "0")
            {
                Dictionary<string, string> idNameDic = new Dictionary<string, string>();
                string exception = "";
                if (CommonCtrl.GetOfficeIdNameDicByDepartId(ref idNameDic, departId, ref exception))
                {
                    foreach (string id in idNameDic.Keys)
                    {
                        DropDownList_Office.Items.Add(idNameDic[id], id);
                    }
                }
            }
        }
        #endregion
    }
}