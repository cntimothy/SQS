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

        /// <summary>
        /// 创建分数Excel
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="departList">部系列表</param>
        /// <param name="exception"></param>
        /// <returns>创建成功返回true，否则返回false</returns>
        public static bool ExportScores(ref string fileName, List<DepartScore> departList, ref string exception)
        {
            bool returnValue = true;

            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            ISheet sheet = hssfworkbook.CreateSheet("输出总表");

            CellRangeAddress region;

            //设置宽度
            sheet.SetColumnWidth(0, 9 * 256);
            sheet.SetColumnWidth(1, 28 * 256);
            sheet.SetColumnWidth(2, 9 * 256);
            sheet.SetColumnWidth(3, 8 * 256);
            sheet.SetColumnWidth(4, 8 * 256);
            sheet.SetColumnWidth(5, 8 * 256);
            sheet.SetColumnWidth(6, 8 * 256);
            sheet.SetColumnWidth(7, 8 * 256);
            sheet.SetColumnWidth(8, 8 * 256);
            sheet.SetColumnWidth(9, 8 * 256);
            sheet.SetColumnWidth(10, 8 * 256);
            sheet.SetColumnWidth(11, 8 * 256);
            sheet.SetColumnWidth(12, 8 * 256);
            sheet.SetColumnWidth(13, 8 * 256);
            sheet.SetColumnWidth(14, 8 * 256);
            sheet.SetColumnWidth(15, 8 * 256);

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
            normalBoldStyle.WrapText = true;    //自动换行

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

            #region 标题
            IRow row0 = sheet.CreateRow(0);
            row0.HeightInPoints = 40;
            ICell cell00 = row0.CreateCell(0);
            cell00.SetCellValue("政治学院研成果统计表");
            cell00.CellStyle = titleStyle;
            region = new CellRangeAddress(0, 0, 0, 15);
            sheet.AddMergedRegion(region);
            #endregion

            #region 表头
            IRow row1 = sheet.CreateRow(1);
            row1.HeightInPoints = 30;
            ICell cell10 = row1.CreateCell(0);
            cell10.SetCellValue("部系单位");
            cell10.CellStyle = normalBoldStyle;

            ICell cell11 = row1.CreateCell(1);
            cell11.SetCellValue("处室单位");
            cell11.CellStyle = normalBoldStyle;

            ICell cell12 = row1.CreateCell(2);
            cell12.SetCellValue("姓名");
            cell12.CellStyle = normalBoldStyle;

            ICell cell13 = row1.CreateCell(3);
            cell13.SetCellValue("论文得分");
            cell13.CellStyle = normalBoldStyle;

            ICell cell14 = row1.CreateCell(4);
            cell14.SetCellValue("著作得分");
            cell14.CellStyle = normalBoldStyle;

            ICell cell15 = row1.CreateCell(5);
            cell15.SetCellValue("课题得分");
            cell15.CellStyle = normalBoldStyle;

            ICell cell16 = row1.CreateCell(6);
            cell16.SetCellValue("总分");
            cell16.CellStyle = normalBoldStyle;

            ICell cell17 = row1.CreateCell(7);
            cell17.SetCellValue("处室论文总分");
            cell17.CellStyle = normalBoldStyle;

            ICell cell18 = row1.CreateCell(8);
            cell18.SetCellValue("处室著作总分");
            cell18.CellStyle = normalBoldStyle;

            ICell cell19 = row1.CreateCell(9);
            cell19.SetCellValue("处室课题总分");
            cell19.CellStyle = normalBoldStyle;

            ICell cell110 = row1.CreateCell(10);
            cell110.SetCellValue("处室总分");
            cell110.CellStyle = normalBoldStyle;

            ICell cell111 = row1.CreateCell(11);
            cell111.SetCellValue("处室人均成绩");
            cell111.CellStyle = normalBoldStyle;

            ICell cell112 = row1.CreateCell(12);
            cell112.SetCellValue("处室参研率");
            cell112.CellStyle = normalBoldStyle;

            ICell cell113 = row1.CreateCell(13);
            cell113.SetCellValue("部系总成绩");
            cell113.CellStyle = normalBoldStyle;

            ICell cell114 = row1.CreateCell(14);
            cell114.SetCellValue("部系论文人均分");
            cell114.CellStyle = normalBoldStyle;

            ICell cell115 = row1.CreateCell(15);
            cell115.SetCellValue("部系人均分");
            cell115.CellStyle = normalBoldStyle;
            #endregion

            int curRowIndex = 2; //记录当前到第几行了

            //循环部系
            foreach (DepartScore depart in departList)
            {
                //计算部系所占的行数
                int departRowCount = 0;
                foreach (OfficeScore office in depart.OfficeList)
                {
                    departRowCount += office.Staff.Count;
                }

                #region 部系下第一个处室的第一行
                IRow r1 = sheet.CreateRow(curRowIndex);

                //部系单位
                ICell c10 = r1.CreateCell(0);
                c10.SetCellValue(depart.DepartName);
                c10.CellStyle = normalStyle;
                region = new CellRangeAddress(curRowIndex, curRowIndex + departRowCount - 1, 0, 0);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                //处室单位
                ICell c11 = r1.CreateCell(1);
                c11.SetCellValue(depart.OfficeList[0].OfficeName);
                c11.CellStyle = normalStyle;
                region = new CellRangeAddress(curRowIndex, curRowIndex + depart.OfficeList[0].Staff.Count - 1, 1, 1);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                //姓名
                ICell c12 = r1.CreateCell(2);
                c12.SetCellValue(depart.OfficeList[0].Staff[0].Name);
                c12.CellStyle = normalStyle;

                //论文得分
                ICell c13 = r1.CreateCell(3);
                c13.SetCellValue(depart.OfficeList[0].Staff[0].PaperScore);
                c13.CellStyle = normalStyle;

                //著作得分
                ICell c14 = r1.CreateCell(4);
                c14.SetCellValue(depart.OfficeList[0].Staff[0].BookScore);
                c14.CellStyle = normalStyle;

                //课题得分
                ICell c15 = r1.CreateCell(5);
                c15.SetCellValue(depart.OfficeList[0].Staff[0].TopicScore);
                c15.CellStyle = normalStyle;

                //总分
                ICell c16 = r1.CreateCell(6);
                c16.SetCellValue(depart.OfficeList[0].Staff[0].TotalScore);
                c16.CellStyle = normalStyle;

                //处室论文总分
                ICell c17 = r1.CreateCell(7);
                c17.SetCellValue(depart.OfficeList[0].PaperTotalScore);
                c17.CellStyle = normalStyle;

                //处室著作总分
                ICell c18 = r1.CreateCell(8);
                c18.SetCellValue(depart.OfficeList[0].BookTotalScore);
                c18.CellStyle = normalStyle;

                //处室课题总分
                ICell c19 = r1.CreateCell(9);
                c19.SetCellValue(depart.OfficeList[0].TopicTotalScore);
                c19.CellStyle = normalStyle;

                //处室总分
                ICell c110 = r1.CreateCell(10);
                c110.SetCellValue(depart.OfficeList[0].TotalScore);
                c110.CellStyle = normalStyle;

                //处室人均成绩
                ICell c111 = r1.CreateCell(11);
                c111.SetCellValue(depart.OfficeList[0].AverageScore);
                c111.CellStyle = normalStyle;

                //处室参研率
                ICell c112 = r1.CreateCell(12);
                c112.SetCellValue(depart.OfficeList[0].ParticipateRate);
                c112.CellStyle = normalStyle;                

                //部系总成绩
                ICell c113 = r1.CreateCell(13);
                c113.SetCellValue(depart.TotalScore);
                c113.CellStyle = normalStyle;

                //部系论文人均分
                ICell c114 = r1.CreateCell(14);
                c114.SetCellValue(depart.PaperAverageScore);
                c114.CellStyle = normalStyle;

                //部系人均分
                ICell c115 = r1.CreateCell(15);
                c115.SetCellValue(depart.AverageScore);
                c115.CellStyle = normalStyle;
                #endregion
                
                curRowIndex++;

                #region 循环部系下第一个处室除第一个人以外的所有人
                for (int i = 1; i < depart.OfficeList[0].Staff.Count; i++)
                {
                    IRow r2 = sheet.GetRow(curRowIndex);
                    //姓名
                    ICell c22 = r2.CreateCell(2);
                    c22.SetCellValue(depart.OfficeList[0].Staff[i].Name);
                    c22.CellStyle = normalStyle;

                    //论文得分
                    ICell c23 = r2.CreateCell(3);
                    c23.SetCellValue(depart.OfficeList[0].Staff[i].PaperScore);
                    c23.CellStyle = normalStyle;

                    //著作得分
                    ICell c24 = r2.CreateCell(4);
                    c24.SetCellValue(depart.OfficeList[0].Staff[i].BookScore);
                    c24.CellStyle = normalStyle;

                    //课题得分
                    ICell c25 = r2.CreateCell(5);
                    c25.SetCellValue(depart.OfficeList[0].Staff[i].TopicScore);
                    c25.CellStyle = normalStyle;

                    //总分
                    ICell c26 = r2.CreateCell(6);
                    c26.SetCellValue(depart.OfficeList[0].Staff[i].TotalScore);
                    c26.CellStyle = normalStyle;

                    //处室论文总分
                    ICell c27 = r2.CreateCell(7);
                    c27.SetCellValue("");
                    c27.CellStyle = normalStyle;

                    //处室著作总分
                    ICell c28 = r2.CreateCell(8);
                    c28.SetCellValue("");
                    c28.CellStyle = normalStyle;

                    //处室课题总分
                    ICell c29 = r2.CreateCell(9);
                    c29.SetCellValue("");
                    c29.CellStyle = normalStyle;

                    //处室总分
                    ICell c210 = r2.CreateCell(10);
                    c210.SetCellValue("");
                    c210.CellStyle = normalStyle;

                    //处室人均成绩
                    ICell c211 = r2.CreateCell(11);
                    c211.SetCellValue("");
                    c211.CellStyle = normalStyle;

                    //处室参研率
                    ICell c212 = r2.CreateCell(12);
                    c212.SetCellValue("");
                    c212.CellStyle = normalStyle;

                    //部系总成绩
                    ICell c213 = r2.CreateCell(13);
                    c213.SetCellValue("");
                    c213.CellStyle = normalStyle;

                    //部系论文人均分
                    ICell c214 = r2.CreateCell(14);
                    c214.SetCellValue("");
                    c214.CellStyle = normalStyle;

                    //部系人均分
                    ICell c215 = r2.CreateCell(15);
                    c215.SetCellValue("");
                    c215.CellStyle = normalStyle;

                    curRowIndex++;
                }
                #endregion

                //循环必须下除第一个以外的所有处室
                for (int i = 1; i < depart.OfficeList.Count; i++)
                {
                    #region 处室的第一行
                    IRow r3 = sheet.GetRow(curRowIndex);

                    ICell c31 = r3.CreateCell(1);
                    c31.SetCellValue(depart.OfficeList[i].OfficeName);
                    c31.CellStyle = normalStyle;
                    region = new CellRangeAddress(curRowIndex, curRowIndex + depart.OfficeList[i].Staff.Count - 1, 1, 1);
                    sheet.AddMergedRegion(region);
                    ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                    //姓名
                    ICell c32 = r3.CreateCell(2);
                    c32.SetCellValue(depart.OfficeList[i].Staff[0].Name);
                    c32.CellStyle = normalStyle;

                    //论文得分
                    ICell c33 = r3.CreateCell(3);
                    c33.SetCellValue(depart.OfficeList[i].Staff[0].PaperScore);
                    c33.CellStyle = normalStyle;

                    //著作得分
                    ICell c34 = r3.CreateCell(4);
                    c34.SetCellValue(depart.OfficeList[i].Staff[0].BookScore);
                    c34.CellStyle = normalStyle;

                    //课题得分
                    ICell c35 = r3.CreateCell(5);
                    c35.SetCellValue(depart.OfficeList[i].Staff[0].TopicScore);
                    c35.CellStyle = normalStyle;

                    //总分
                    ICell c36 = r3.CreateCell(6);
                    c36.SetCellValue(depart.OfficeList[i].Staff[0].TotalScore);
                    c36.CellStyle = normalStyle;

                    //处室论文总分
                    ICell c37 = r3.CreateCell(7);
                    c37.SetCellValue(depart.OfficeList[i].PaperTotalScore);
                    c37.CellStyle = normalStyle;

                    //处室著作总分
                    ICell c38 = r3.CreateCell(8);
                    c38.SetCellValue(depart.OfficeList[i].BookTotalScore);
                    c38.CellStyle = normalStyle;

                    //处室课题总分
                    ICell c39 = r3.CreateCell(9);
                    c39.SetCellValue(depart.OfficeList[i].TopicTotalScore);
                    c39.CellStyle = normalStyle;

                    //处室总分
                    ICell c310 = r3.CreateCell(10);
                    c310.SetCellValue(depart.OfficeList[i].TotalScore);
                    c310.CellStyle = normalStyle;

                    //处室人均成绩
                    ICell c311 = r3.CreateCell(11);
                    c311.SetCellValue(depart.OfficeList[i].AverageScore);
                    c311.CellStyle = normalStyle;

                    //处室参研率
                    ICell c312 = r3.CreateCell(12);
                    c312.SetCellValue(depart.OfficeList[i].ParticipateRate);
                    c312.CellStyle = normalStyle;

                    //部系总成绩
                    ICell c313 = r3.CreateCell(13);
                    c313.SetCellValue("");
                    c313.CellStyle = normalStyle;

                    //部系论文人均分
                    ICell c314 = r3.CreateCell(14);
                    c314.SetCellValue("");
                    c314.CellStyle = normalStyle;

                    //部系人均分
                    ICell c315 = r3.CreateCell(15);
                    c315.SetCellValue("");
                    c315.CellStyle = normalStyle;
                    #endregion

                    curRowIndex++;

                    //循环处室除第一个人以外的所有人
                    for (int j = 1; j < depart.OfficeList[i].Staff.Count; j++)
                    {
                        IRow r4 = sheet.GetRow(curRowIndex);

                        //姓名
                        ICell c42 = r4.CreateCell(2);
                        c42.SetCellValue(depart.OfficeList[i].Staff[0].Name);
                        c42.CellStyle = normalStyle;

                        //论文得分
                        ICell c43 = r4.CreateCell(3);
                        c43.SetCellValue(depart.OfficeList[i].Staff[0].PaperScore);
                        c43.CellStyle = normalStyle;

                        //著作得分
                        ICell c44 = r4.CreateCell(4);
                        c44.SetCellValue(depart.OfficeList[i].Staff[0].BookScore);
                        c44.CellStyle = normalStyle;

                        //课题得分
                        ICell c45 = r4.CreateCell(5);
                        c45.SetCellValue(depart.OfficeList[i].Staff[0].TopicScore);
                        c45.CellStyle = normalStyle;

                        //总分
                        ICell c46 = r4.CreateCell(6);
                        c46.SetCellValue(depart.OfficeList[i].Staff[0].TotalScore);
                        c46.CellStyle = normalStyle;

                        //处室论文总分
                        ICell c47 = r4.CreateCell(7);
                        c47.SetCellValue("");
                        c47.CellStyle = normalStyle;

                        //处室著作总分
                        ICell c48 = r4.CreateCell(8);
                        c48.SetCellValue("");
                        c48.CellStyle = normalStyle;

                        //处室课题总分
                        ICell c49 = r4.CreateCell(9);
                        c49.SetCellValue("");
                        c49.CellStyle = normalStyle;

                        //处室总分
                        ICell c410 = r4.CreateCell(10);
                        c410.SetCellValue("");
                        c410.CellStyle = normalStyle;

                        //处室人均成绩
                        ICell c411 = r4.CreateCell(11);
                        c411.SetCellValue("");
                        c411.CellStyle = normalStyle;

                        //处室参研率
                        ICell c412 = r4.CreateCell(12);
                        c412.SetCellValue("");
                        c412.CellStyle = normalStyle;

                        //部系总成绩
                        ICell c413 = r4.CreateCell(13);
                        c413.SetCellValue("");
                        c413.CellStyle = normalStyle;

                        //部系论文人均分
                        ICell c414 = r4.CreateCell(14);
                        c414.SetCellValue("");
                        c414.CellStyle = normalStyle;

                        //部系人均分
                        ICell c415 = r4.CreateCell(15);
                        c415.SetCellValue("");
                        c415.CellStyle = normalStyle;

                        curRowIndex++;
                    }
                }
            }


            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"科研成果统计表.xls";
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
        /// 创建搜索结果Excel
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportSearchResult(ref string fileName, DataTable tableForPaper, DataTable tableForBook, DataTable tableForTopic, ref string exception)
        {
            bool returnValue = true;
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            createSheetFromDataTable("论文", "论文搜索结果", hssfworkbook, tableForPaper);  //建立论文sheet
            createSheetFromDataTable("著作", "著作搜索结果", hssfworkbook, tableForBook);  //建立著作sheet
            createSheetFromDataTable("课题", "课题搜索结果", hssfworkbook, tableForTopic);  //建立课题sheet

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + @"搜索结果.xls";
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
