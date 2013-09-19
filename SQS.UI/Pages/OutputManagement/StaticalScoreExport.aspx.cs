using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.DataStructure;
using SQS.Controller;
using System.Data;

namespace SQS.UI.Pages.OutputManagement
{
    public partial class StaticalResultExport : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindYearToDropDownList();
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// 生成结果事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_GetResult_Click(object sender, EventArgs e)
        {
            if (DropDownList_StartYear.SelectedValue == "0")
            {
                Alert.ShowInTop("请选择开始年份！", MessageBoxIcon.Warning);
                return;
            }
            if (DropDownList_StopYear.SelectedValue == "0")
            {
                Alert.ShowInTop("请选择结束年份！", MessageBoxIcon.Warning);
                return;
            }
            string startTime = DropDownList_StartYear.SelectedValue + "-" + DropDownList_StartMonth.SelectedValue;
            string stopTime = DropDownList_StopYear.SelectedValue + "-" + DropDownList_StopMonth.SelectedValue;

            DateTime d1 = Convert.ToDateTime(startTime);
            DateTime d2 = Convert.ToDateTime(stopTime);
            if (d1 > d2)
            {
                Alert.ShowInTop("结束时间必须大于开始时间！", MessageBoxIcon.Warning);
                return;
            }

            List<DepartScore> departList = new List<DepartScore>();
            string exception = "";
            if (OutputManagementCtrl.GetScoreResult(ref departList, startTime, stopTime, ref exception))
            {
                DataTable table = getDataTable(departList);
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
            else
            {
                Alert.ShowInTop(exception);
                DataTable table = new DataTable();
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }

        /// <summary>
        /// 导出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Export_Click(object sender, EventArgs e)
        {
            if (DropDownList_StartYear.SelectedValue == "0")
            {
                Alert.ShowInTop("请选择开始年份！", MessageBoxIcon.Warning);
                return;
            }
            if (DropDownList_StopYear.SelectedValue == "0")
            {
                Alert.ShowInTop("请选择结束年份！", MessageBoxIcon.Warning);
                return;
            }
            string startTime = DropDownList_StartYear.SelectedValue + "-" + DropDownList_StartMonth.SelectedValue;
            string stopTime = DropDownList_StopYear.SelectedValue + "-" + DropDownList_StopMonth.SelectedValue;

            DateTime d1 = Convert.ToDateTime(startTime);
            DateTime d2 = Convert.ToDateTime(stopTime);
            if (d1 > d2)
            {
                Alert.ShowInTop("结束时间必须大于开始时间！", MessageBoxIcon.Warning);
                return;
            }

            List<DepartScore> departList = new List<DepartScore>();
            string exception = "";
            if (OutputManagementCtrl.GetScoreResult(ref departList, startTime, stopTime, ref exception))
            {
                string fileName = "";
                if (ExportManagementCtrl.ExportScores(ref fileName, departList, ref exception))
                {
                    Response.ClearContent();
                    Response.ContentType = "application/excel";
                    Response.AddHeader("content-disposition", "attachment;filename=" + Server.UrlEncode(fileName));
                    string path = Server.MapPath("..\\..\\downloadfiles\\" + fileName);
                    Response.TransmitFile(path);
                }
                else
                {
                    Alert.ShowInTop("导出失败！\n原因：" + exception, MessageBoxIcon.Error);
                }
            }
            else
            {
                Alert.ShowInTop(exception);
                DataTable table = new DataTable();
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
            
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 绑定年份到下拉列表
        /// </summary>
        private void bindYearToDropDownList()
        {
            string exception = "";
            List<string> yearList = new List<string>();
            if (CommonCtrl.GetYearList(ref yearList, ref exception))
            {
                foreach (string year in yearList)
                {
                    DropDownList_StartYear.Items.Add(year, year);
                    DropDownList_StopYear.Items.Add(year, year);
                }
            }
        }
        
        /// <summary>
        /// 根据departList的内容填充DataTable
        /// </summary>
        /// <param name="departList"></param>
        /// <returns></returns>
        private DataTable getDataTable(List<DepartScore> departList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Depart");
            table.Columns.Add("Office");
            table.Columns.Add("Name");
            table.Columns.Add("PaperScore");
            table.Columns.Add("BookScore");
            table.Columns.Add("TopicScore");
            table.Columns.Add("TotalScore");
            table.Columns.Add("OfficePaperScore");
            table.Columns.Add("OfficeBookScore");
            table.Columns.Add("OfficeTopicScore");
            table.Columns.Add("OfficeTotalScore");
            table.Columns.Add("OfficeAverageScore");
            table.Columns.Add("OfficeParticipateRate");
            table.Columns.Add("DepartTotalScore");
            table.Columns.Add("DepartPaperAverageScore");
            table.Columns.Add("DepartAverageScore");
         
            foreach (DepartScore depart in departList)
            {
                //每个部系的第一行
                DataRow row1 = table.NewRow();
                row1["Depart"] = depart.DepartName;
                row1["Office"] = depart.OfficeList[0].OfficeName;
                row1["Name"] = depart.OfficeList[0].Staff[0].Name;
                row1["PaperScore"] = depart.OfficeList[0].Staff[0].PaperScore;
                row1["BookScore"] = depart.OfficeList[0].Staff[0].BookScore;
                row1["TopicScore"] = depart.OfficeList[0].Staff[0].TopicScore;
                row1["OfficePaperScore"] = depart.OfficeList[0].PaperTotalScore;
                row1["OfficeBookScore"] = depart.OfficeList[0].BookTotalScore;
                row1["OfficeTopicScore"] = depart.OfficeList[0].TopicTotalScore;
                row1["OfficeTotalScore"] = depart.OfficeList[0].TotalScore;
                row1["OfficeAverageScore"] = depart.OfficeList[0].AverageScore;
                row1["OfficeParticipateRate"] = depart.OfficeList[0].ParticipateRate;
                row1["DepartTotalScore"] = depart.TotalScore;
                row1["DepartPaperAverageScore"] = depart.PaperAverageScore;
                row1["DepartAverageScore"] = depart.AverageScore;
                table.Rows.Add(row1);

                //循环部系下的处室（除了第一个）
                for (int i = 1; i < depart.OfficeList.Count; i++)
                {
                    DataRow row2 = table.NewRow();
                    row2["Depart"] = "";
                    row2["Office"] = depart.OfficeList[i].OfficeName;
                    row2["Name"] = depart.OfficeList[i].Staff[0].Name;
                    row2["PaperScore"] = depart.OfficeList[i].Staff[0].PaperScore;
                    row2["BookScore"] = depart.OfficeList[i].Staff[0].BookScore;
                    row2["TopicScore"] = depart.OfficeList[i].Staff[0].TopicScore;
                    row2["OfficePaperScore"] = depart.OfficeList[i].PaperTotalScore;
                    row2["OfficeBookScore"] = depart.OfficeList[i].BookTotalScore;
                    row2["OfficeTopicScore"] = depart.OfficeList[i].TopicTotalScore;
                    row2["OfficeTotalScore"] = depart.OfficeList[i].TotalScore;
                    row2["OfficeAverageScore"] = depart.OfficeList[i].AverageScore;
                    row2["OfficeParticipateRate"] = depart.OfficeList[i].ParticipateRate;
                    row2["DepartTotalScore"] = "";
                    row2["DepartPaperAverageScore"] = "";
                    row2["DepartAverageScore"] = "";
                    table.Rows.Add(row2);

                    //循环处室下的人（除了第一个）
                    for (int j = 1; j < depart.OfficeList[i].Staff.Count; j++)
                    {
                        DataRow row3 = table.NewRow();
                        row3["Depart"] = "";
                        row3["Office"] = "";
                        row3["Name"] = depart.OfficeList[i].Staff[j].Name;
                        row3["PaperScore"] = depart.OfficeList[i].Staff[j].PaperScore;
                        row3["BookScore"] = depart.OfficeList[i].Staff[j].BookScore;
                        row3["TopicScore"] = depart.OfficeList[i].Staff[j].TopicScore;
                        row3["OfficePaperScore"] = "";
                        row3["OfficeBookScore"] = "";
                        row3["OfficeTopicScore"] = "";
                        row3["OfficeTotalScore"] = "";
                        row3["OfficeAverageScore"] = "";
                        row3["OfficeParticipateRate"] = "";
                        row3["DepartTotalScore"] = "";
                        row3["DepartPaperAverageScore"] = "";
                        row3["DepartAverageScore"] = "";
                        table.Rows.Add(row3);
                    }
                }
            }

            return table;
        }
        #endregion
    }
}