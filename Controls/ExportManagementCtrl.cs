using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.IO;
using SQS.DataStructure;

namespace SQS.Controller
{
    public class ExportManagementCtrl
    {
        #region Public Method
        /// <summary>
        /// 创建著作信息Excel
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
        /// 创建论文信息Excel
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

        /// <summary>
        /// 创建课题信息Excel
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns>创建成功返回true，否则返回false</returns>
        public static bool ExportTopicInformation(ref string fileName, DataTable table, ref string exception)
        {
            bool returnValue = true;
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            createSheetFromDataTable("课题", "课题统计表", hssfworkbook, table);  //建立sheet

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"课题统计表.xls";
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
        /// 创建人员信息Excel
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="departList">部门列表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportStaffInformation(ref string fileName, List<DepartStaffInformation> departList, ref string exception)
        {
            bool returnValue = true;

            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            ISheet sheet = hssfworkbook.CreateSheet("人员信息表");

            CellRangeAddress region;

            //设置宽度
            sheet.SetColumnWidth(0, 18 * 256);
            sheet.SetColumnWidth(1, 28 * 256);
            sheet.SetColumnWidth(2, 10 * 256);
            sheet.SetColumnWidth(3, 10 * 256);

            //标题格式（居中加黑大字）
            ICellStyle titleStyle = hssfworkbook.CreateCellStyle();
            titleStyle.Alignment = HorizontalAlignment.CENTER;
            titleStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont titleFont = hssfworkbook.CreateFont();
            titleFont.FontName = "宋体";
            titleFont.FontHeightInPoints = 22;
            titleFont.Boldweight = (short)FontBoldWeight.BOLD;
            titleStyle.SetFont(titleFont);

            //表头格式（居中加黑小字）
            ICellStyle normalBoldStyle = hssfworkbook.CreateCellStyle();
            normalBoldStyle.Alignment = HorizontalAlignment.CENTER;
            normalBoldStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldFont = hssfworkbook.CreateFont();
            normalBoldFont.FontName = "宋体";
            normalBoldFont.FontHeightInPoints = 10;
            normalBoldFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldStyle.SetFont(normalBoldFont);
            normalBoldStyle.BorderTop = BorderStyle.THIN;
            normalBoldStyle.BorderBottom = BorderStyle.THIN;
            normalBoldStyle.BorderLeft = BorderStyle.THIN;
            normalBoldStyle.BorderRight = BorderStyle.THIN;

            //内容格式（居中不加黑小字）
            ICellStyle normalStyle = hssfworkbook.CreateCellStyle();
            normalStyle.Alignment = HorizontalAlignment.CENTER;
            normalStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalFont = hssfworkbook.CreateFont();
            normalFont.FontName = "宋体";
            normalFont.FontHeightInPoints = 10;
            normalStyle.SetFont(normalFont);
            normalStyle.BorderTop = BorderStyle.THIN;
            normalStyle.BorderBottom = BorderStyle.THIN;
            normalStyle.BorderLeft = BorderStyle.THIN;
            normalStyle.BorderRight = BorderStyle.THIN;

            //标题
            IRow row0 = sheet.CreateRow(0);
            row0.HeightInPoints = 40;
            ICell cell00 = row0.CreateCell(0);
            cell00.SetCellValue("人员信息表");
            cell00.CellStyle = titleStyle;
            region = new CellRangeAddress(0, 0, 0, 3);
            sheet.AddMergedRegion(region);

            //表头
            IRow row1 = sheet.CreateRow(1);
            row1.HeightInPoints = 30;
            ICell cell10 = row1.CreateCell(0);
            cell10.SetCellValue("部系单位");
            cell10.CellStyle = normalBoldStyle; 
            region = new CellRangeAddress(1, 2, 0, 0);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cell11 = row1.CreateCell(1);
            cell11.SetCellValue("处室单位");
            cell11.CellStyle = normalBoldStyle;
            region = new CellRangeAddress(1, 2, 1, 1);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cell12 = row1.CreateCell(2);
            cell12.SetCellValue("实际在位人数");
            cell12.CellStyle = normalBoldStyle;
            region = new CellRangeAddress(1, 1, 2, 3);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            IRow row2 = sheet.GetRow(2);
            ICell cell22 = row2.CreateCell(2);
            cell22.SetCellValue("处室人数");
            cell22.CellStyle = normalBoldStyle;

            ICell cell23 = row2.CreateCell(3);
            cell23.SetCellValue("部系人数");
            cell23.CellStyle = normalBoldStyle;

            int curRowIndex = 3; //记录当前到第几行了

            foreach (DepartStaffInformation depart in departList)
            {
                IRow r1 = sheet.CreateRow(curRowIndex);
                ICell c10 = r1.CreateCell(0);
                c10.SetCellValue(depart.Name);
                c10.CellStyle = normalStyle;
                region = new CellRangeAddress(curRowIndex, curRowIndex + depart.Offices.Count - 1, 0, 0);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell c11 = r1.CreateCell(1);
                c11.SetCellValue(depart.Offices[0].Name);
                c11.CellStyle = normalStyle;

                ICell c12 = r1.CreateCell(2);
                c12.SetCellValue(depart.Offices[0].StaffCount);
                c12.CellStyle = normalStyle;

                ICell c13 = r1.CreateCell(3);
                c13.SetCellValue(depart.StaffCount);
                c13.CellStyle = normalStyle;
                region = new CellRangeAddress(curRowIndex, curRowIndex + depart.Offices.Count - 1, 3, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                for (int i = 1; i < depart.Offices.Count; i++)
                {
                    IRow r2 = sheet.GetRow(curRowIndex + i);
                    ICell c21 = r2.CreateCell(1);
                    c21.SetCellValue(depart.Offices[i].Name);
                    c21.CellStyle = normalStyle;

                    ICell c22 = r2.CreateCell(2);
                    c22.SetCellValue(depart.Offices[i].StaffCount);
                    c22.CellStyle = normalStyle;
                }

                curRowIndex += depart.Offices.Count;
            }

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"人员信息表.xls";
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
        /// 创建部系数量统计Excel
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportStaticalCountForDepart(ref string fileName, DataTable table, ref string exception)
        {
            bool returnValue = true;
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            createSheetFromDataTable("部系", "部系成果统计表", hssfworkbook, table);  //建立sheet

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"部系成果统计表.xls";
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
        /// 创建处室数量统计Excel
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportStaticalCountForOffice(ref string fileName, DataTable table, ref string exception)
        {
            bool returnValue = true;
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            createSheetFromDataTable("处室", "处室成果统计表", hssfworkbook, table);  //建立sheet

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"处室成果统计表.xls";
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
            ICellStyle normalBoldStyle = workBook.CreateCellStyle();
            normalBoldStyle.Alignment = HorizontalAlignment.CENTER;
            normalBoldStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldFont = workBook.CreateFont();
            normalBoldFont.FontName = "宋体";
            normalBoldFont.FontHeightInPoints = 10;
            normalBoldFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldStyle.SetFont(normalBoldFont);
            normalBoldStyle.BorderTop = BorderStyle.THIN;
            normalBoldStyle.BorderBottom = BorderStyle.THIN;
            normalBoldStyle.BorderLeft = BorderStyle.THIN;
            normalBoldStyle.BorderRight = BorderStyle.THIN;

            //内容格式（居左不加黑小字）
            ICellStyle normalStyle = workBook.CreateCellStyle();
            normalStyle.Alignment = HorizontalAlignment.LEFT;
            normalStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont NormalFont = workBook.CreateFont();
            NormalFont.FontName = "宋体";
            NormalFont.FontHeightInPoints = 10;
            normalStyle.SetFont(NormalFont);
            normalStyle.BorderTop = BorderStyle.THIN;
            normalStyle.BorderBottom = BorderStyle.THIN;
            normalStyle.BorderLeft = BorderStyle.THIN;
            normalStyle.BorderRight = BorderStyle.THIN;

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
                cell.CellStyle = normalBoldStyle;
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
                    cell.CellStyle = normalStyle;
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
