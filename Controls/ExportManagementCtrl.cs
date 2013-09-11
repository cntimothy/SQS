using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.IO;

namespace SQS.Controller
{
    public class ExportManagementCtrl
    {
        #region Public Method
        /// <summary>
        /// 穿件著作信息Excel
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns>创建成功返回true，否则返回false</returns>
        public static bool ExportBookInformation(ref string fileName, DataTable table, ref string exception)
        {
            bool returnValue = true;
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            createSheetFromDataTable("著作", "著作统计表", hssfworkbook, table);  //建立sheet

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"著作统计表.xls";
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + fileName;
            FileStream file = new FileStream(path, FileMode.Create);
            try
            {
                hssfworkbook.Write(file);
            }
            catch (Exception e)
            {
                exception = e.Message;
                returnValue = false;
            }
            finally
            {
                file.Close();
            }
            return returnValue;
        }

        /// <summary>
        /// 穿件论文信息Excel
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns>创建成功返回true，否则返回false</returns>
        public static bool ExportPaperInformation(ref string fileName, DataTable table, ref string exception)
        {
            bool returnValue = true;
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            createSheetFromDataTable("论文", "论文统计表", hssfworkbook, table);  //建立sheet

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"论文统计表.xls";
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + fileName;
            FileStream file = new FileStream(path, FileMode.Create);
            try
            {
                hssfworkbook.Write(file);
            }
            catch (Exception e)
            {
                exception = e.Message;
                returnValue = false;
            }
            finally
            {
                file.Close();
            }
            return returnValue;
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 根据DataTable项workBook中添加sheet，sheet中的列名即为DataTable中的列明
        /// </summary>
        /// <param name="sheetName">sheet的名称</param>
        /// <param name="title">sheet中的标题</param>
        /// <param name="workBook"></param>
        /// <param name="table"></param>
        private static void createSheetFromDataTable(string sheetName, string title, HSSFWorkbook workBook, DataTable table)
        {
            ISheet sheet = workBook.CreateSheet(sheetName);

            int columnsCount = table.Columns.Count;

            CellRangeAddress region;

            //标题格式（居中加黑大字）
            ICellStyle titleStyle = workBook.CreateCellStyle();
            titleStyle.Alignment = HorizontalAlignment.CENTER;
            titleStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont titleFont = workBook.CreateFont();
            titleFont.FontName = "宋体";
            titleFont.FontHeightInPoints = 22;
            titleFont.Boldweight = (short)FontBoldWeight.BOLD;
            titleStyle.SetFont(titleFont);

            //表头格式（居中加黑小字）
            ICellStyle NormalBoldStyle = workBook.CreateCellStyle();
            NormalBoldStyle.Alignment = HorizontalAlignment.CENTER;
            NormalBoldStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont NormalBoldFont = workBook.CreateFont();
            NormalBoldFont.FontName = "宋体";
            NormalBoldFont.FontHeightInPoints = 10;
            NormalBoldFont.Boldweight = (short)FontBoldWeight.BOLD;
            NormalBoldStyle.SetFont(NormalBoldFont);
            NormalBoldStyle.BorderTop = BorderStyle.THIN;
            NormalBoldStyle.BorderBottom = BorderStyle.THIN;
            NormalBoldStyle.BorderLeft = BorderStyle.THIN;
            NormalBoldStyle.BorderRight = BorderStyle.THIN;

            //内容格式（居左不加黑小字）
            ICellStyle NormalStyle = workBook.CreateCellStyle();
            NormalStyle.Alignment = HorizontalAlignment.LEFT;
            NormalStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont NormalFont = workBook.CreateFont();
            NormalFont.FontName = "宋体";
            NormalFont.FontHeightInPoints = 10;
            NormalStyle.SetFont(NormalFont);
            NormalStyle.BorderTop = BorderStyle.THIN;
            NormalStyle.BorderBottom = BorderStyle.THIN;
            NormalStyle.BorderLeft = BorderStyle.THIN;
            NormalStyle.BorderRight = BorderStyle.THIN;

            //标题行
            IRow row0 = sheet.CreateRow(0);
            row0.HeightInPoints = 40;
            ICell cell00 = row0.CreateCell(0);
            cell00.SetCellValue(title);
            cell00.CellStyle = titleStyle;
            region = new CellRangeAddress(0, 0, 0, columnsCount-1);
            sheet.AddMergedRegion(region);

            //表头
            IRow row1 = sheet.CreateRow(1);
            row1.HeightInPoints = 30;
            int columnIndex = 0;
            foreach (DataColumn column in table.Columns)
            {
                ICell cell = row1.CreateCell(columnIndex);
                cell.SetCellValue(column.ColumnName);
                cell.CellStyle = NormalBoldStyle;
                columnIndex++;
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 2);
                row.HeightInPoints = 25;
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    ICell cell = row.CreateCell(j);
                    cell.SetCellValue(table.Rows[i][j].ToString());
                    cell.CellStyle = NormalStyle;
                }
            }
        }

        /// <summary>
        /// 给table增加序号列
        /// </summary>
        /// <param name="table"></param>
        private void manageDataTable(ref DataTable table)
        {
            table.Columns.Remove("ID");
            table.Columns.Add("序号");
            int index = 1;
            foreach (DataRow row in table.Rows)
            {
                row["序号"] = index++;
            }
        }
        #endregion
    }
}
