using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQS.DataStructure;
using System.Data;

namespace SQS.Controller
{
    public class OutputManagementCtrl
    {
        /// <summary>
        /// 获取分数输出总表
        /// </summary>
        /// <param name="departScoreList"></param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetScoreResult(ref List<DepartScore> departScoreList, string startDate, string stopDate, ref string exception)
        {
            IndividualScore individual1 = new IndividualScore("高1", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual2 = new IndividualScore("高2", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual3 = new IndividualScore("高3", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual4 = new IndividualScore("高4", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual5 = new IndividualScore("高5", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual6 = new IndividualScore("高6", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual7 = new IndividualScore("高7", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual8 = new IndividualScore("高8", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual9 = new IndividualScore("高9", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual10 = new IndividualScore("高10", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual11 = new IndividualScore("高11", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual12 = new IndividualScore("高12", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual13 = new IndividualScore("高13", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual14 = new IndividualScore("高14", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual15 = new IndividualScore("高15", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual16 = new IndividualScore("高16", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual17 = new IndividualScore("高17", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual18 = new IndividualScore("高18", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual19 = new IndividualScore("高19", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual20 = new IndividualScore("高20", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual21 = new IndividualScore("高21", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual22 = new IndividualScore("高22", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual23 = new IndividualScore("高23", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual24 = new IndividualScore("高24", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual25 = new IndividualScore("高25", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual26 = new IndividualScore("高26", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual27 = new IndividualScore("高27", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual28 = new IndividualScore("高28", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual29 = new IndividualScore("高29", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual30 = new IndividualScore("高30", 22.3f, 33.4f, 34.9f, 33.8f);
            IndividualScore individual31 = new IndividualScore("高31", 22.3f, 33.4f, 34.9f, 33.8f);

            OfficeScore office1 = new OfficeScore("处室1", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office2 = new OfficeScore("处室2", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office3 = new OfficeScore("处室3", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office4 = new OfficeScore("处室4", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office5 = new OfficeScore("处室5", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office6 = new OfficeScore("处室6", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office7 = new OfficeScore("处室7", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office8 = new OfficeScore("处室8", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office9 = new OfficeScore("处室9", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office10 = new OfficeScore("处室10", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office11 = new OfficeScore("处室11", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office12 = new OfficeScore("处室12", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);
            OfficeScore office13 = new OfficeScore("处室13", 33.9f, 78.8f, 89.2f, 45.6f, 78.4f, 78.9f);

            DepartScore depart1 = new DepartScore("部系1", 89.4f, 87.3f, 78.9f);
            DepartScore depart2 = new DepartScore("部系2", 89.4f, 87.2f, 78.9f);
            DepartScore depart3 = new DepartScore("部系3", 89.4f, 87.7f, 78.9f);

            office1.Staff.Add(individual1);
            office1.Staff.Add(individual2);
            office1.Staff.Add(individual3);
            office2.Staff.Add(individual4);
            office2.Staff.Add(individual5);
            office2.Staff.Add(individual6);
            office3.Staff.Add(individual7);
            office3.Staff.Add(individual8);
            office3.Staff.Add(individual9);
            office3.Staff.Add(individual10);
            office4.Staff.Add(individual11);
            office4.Staff.Add(individual12);
            office5.Staff.Add(individual13);
            office5.Staff.Add(individual14);
            office5.Staff.Add(individual15);
            office5.Staff.Add(individual16);
            office5.Staff.Add(individual17);
            office6.Staff.Add(individual18);
            office6.Staff.Add(individual19);
            office6.Staff.Add(individual20);
            office6.Staff.Add(individual21);
            office7.Staff.Add(individual22);
            office7.Staff.Add(individual23);
            office8.Staff.Add(individual24);
            office9.Staff.Add(individual25);
            office9.Staff.Add(individual26);
            office10.Staff.Add(individual27);
            office11.Staff.Add(individual28);
            office11.Staff.Add(individual29);
            office12.Staff.Add(individual30);
            office13.Staff.Add(individual31);

            depart1.OfficeList.Add(office1);
            depart1.OfficeList.Add(office2);
            depart1.OfficeList.Add(office3);
            depart2.OfficeList.Add(office4);
            depart2.OfficeList.Add(office5);
            depart2.OfficeList.Add(office6);
            depart2.OfficeList.Add(office7);
            depart2.OfficeList.Add(office8);
            depart3.OfficeList.Add(office9);
            depart3.OfficeList.Add(office10);
            depart3.OfficeList.Add(office11);
            depart3.OfficeList.Add(office12);
            depart3.OfficeList.Add(office13);

            departScoreList.Add(depart1);
            departScoreList.Add(depart2);
            departScoreList.Add(depart3);
            return true;
        }

        /// <summary>
        /// 获取各个处室各等级科研成果数量输出总表（按部系排序、注意相同成果只能算一篇）
        /// </summary>
        /// <param name="table">(Depart, Office, PaperPublishGrade1~4, PaperRewardGrade1~3, PaperRewardClass1~3, BookPublishGrade1~3, BookRewardGrade1~3, BookRewardClass1~3, TopicPublishGrade1~4, TopicRewardGrade1~3, TopicRewardClass1~3)</param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetCountResultForOffice(ref DataTable table, string startDate, string stopDate, ref string exception)
        {
            table.Columns.Add("Depart");
            table.Columns.Add("Office");
            table.Columns.Add("PaperPublishGrade1");
            table.Columns.Add("PaperPublishGrade2");
            table.Columns.Add("PaperPublishGrade3");
            table.Columns.Add("PaperPublishGrade4");
            table.Columns.Add("PaperRewardGrade1");
            table.Columns.Add("PaperRewardGrade2");
            table.Columns.Add("PaperRewardGrade3");
            table.Columns.Add("PaperRewardClass1");
            table.Columns.Add("PaperRewardClass2");
            table.Columns.Add("PaperRewardClass3");
            table.Columns.Add("BookPublishGrade1");
            table.Columns.Add("BookPublishGrade2");
            table.Columns.Add("BookPublishGrade3");
            table.Columns.Add("BookRewardGrade1");
            table.Columns.Add("BookRewardGrade2");
            table.Columns.Add("BookRewardGrade3");
            table.Columns.Add("BookRewardClass1");
            table.Columns.Add("BookRewardClass2");
            table.Columns.Add("BookRewardClass3");
            table.Columns.Add("TopicPublishGrade1");
            table.Columns.Add("TopicPublishGrade2");
            table.Columns.Add("TopicPublishGrade3");
            table.Columns.Add("TopicPublishGrade4");
            table.Columns.Add("TopicRewardGrade1");
            table.Columns.Add("TopicRewardGrade2");
            table.Columns.Add("TopicRewardGrade3");
            table.Columns.Add("TopicRewardClass1");
            table.Columns.Add("TopicRewardClass2");
            table.Columns.Add("TopicRewardClass3");

            table.Rows.Add("部系1", "处室1", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系2", "处室2", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系3", "处室3", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系4", "处室4", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系5", "处室5", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系6", "处室6", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系7", "处室7", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系8", "处室8", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系9", "处室9", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系10", "处室10", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系11", "处室11", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系12", "处室12", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系13", "处室13", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系14", "处室14", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系15", "处室15", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系16", "处室16", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系17", "处室17", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系18", "处室18", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系19", "处室19", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系20", "处室20", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系21", "处室21", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系22", "处室22", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系23", "处室23", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            return true;
        }

        /// <summary>
        /// 获取各个部系各等级科研成果数量输出总表（按部系排序、注意相同成果只能算一篇）
        /// </summary>
        /// <param name="table">(Depart, PaperPublishGrade1~4, PaperRewardGrade1~3, PaperRewardClass1~3, BookPublishGrade1~3, BookRewardGrade1~3, BookRewardClass1~3, TopicPublishGrade1~4, TopicRewardGrade1~3, TopicRewardClass1~3)</param>
        /// <param name="startDate">开始年月</param>
        /// <param name="stopDate">结束年月</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetCountResultDepart(ref DataTable table, string startDate, string stopDate, ref string exception)
        {
            table.Columns.Add("Depart");
            table.Columns.Add("PaperPublishGrade1");
            table.Columns.Add("PaperPublishGrade2");
            table.Columns.Add("PaperPublishGrade3");
            table.Columns.Add("PaperPublishGrade4");
            table.Columns.Add("PaperRewardGrade1");
            table.Columns.Add("PaperRewardGrade2");
            table.Columns.Add("PaperRewardGrade3");
            table.Columns.Add("PaperRewardClass1");
            table.Columns.Add("PaperRewardClass2");
            table.Columns.Add("PaperRewardClass3");
            table.Columns.Add("BookPublishGrade1");
            table.Columns.Add("BookPublishGrade2");
            table.Columns.Add("BookPublishGrade3");
            table.Columns.Add("BookRewardGrade1");
            table.Columns.Add("BookRewardGrade2");
            table.Columns.Add("BookRewardGrade3");
            table.Columns.Add("BookRewardClass1");
            table.Columns.Add("BookRewardClass2");
            table.Columns.Add("BookRewardClass3");
            table.Columns.Add("TopicPublishGrade1");
            table.Columns.Add("TopicPublishGrade2");
            table.Columns.Add("TopicPublishGrade3");
            table.Columns.Add("TopicPublishGrade4");
            table.Columns.Add("TopicRewardGrade1");
            table.Columns.Add("TopicRewardGrade2");
            table.Columns.Add("TopicRewardGrade3");
            table.Columns.Add("TopicRewardClass1");
            table.Columns.Add("TopicRewardClass2");
            table.Columns.Add("TopicRewardClass3");

            table.Rows.Add("部系1", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系2", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系3", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系4", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系5", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系6", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系7", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系8", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系9", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系10", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系11", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系12", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系13", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系14", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系15", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系16", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系17", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系18", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系19", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系20", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系21", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系22", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            table.Rows.Add("部系23", "12", "32", "3", "45", "32", "45", "43", "2", "34", "12", "32", "3", "3", "4", "5", "2", "23", "13", "3", "23", "43", "12", "23", "32", "4", "32", "2", "4", "4");
            return true;
        }

        /// <summary>
        /// 获取论文发表级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">论文发表级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetPublishGradeNameListForPaper(ref List<string> nameList, ref string exception)
        {
            nameList.Add("指定报刊");
            nameList.Add("核心报刊");
            nameList.Add("普通报刊");
            nameList.Add("内部期刊");
            return true;
        }

        /// <summary>
        /// 获取著作发行级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">著作发行级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetPublishGradeNameListForBook(ref List<string> nameList, ref string exception)
        {
            nameList.Add("正式出版专著");
            nameList.Add("正式出版");
            nameList.Add("内部印刷");
            return true;
        }

        /// <summary>
        /// 获取课题级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">课题级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetTopicGradeNameList(ref List<string> nameList, ref string exception)
        {
            nameList.Add("国家课题");
            nameList.Add("全军课题");
            nameList.Add("总部课题");
            nameList.Add("院校课题");
            return true;
        }

        /// <summary>
        /// 获取奖励级别名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">奖励级别名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetRewardGrade(ref List<string> nameList, ref string exception)
        {
            nameList.Add("国家级");
            nameList.Add("全军级");
            nameList.Add("总部级");
            return true;
        }

        /// <summary>
        /// 获取奖励等级名称列表（从高等级到低等级）
        /// </summary>
        /// <param name="nameList">奖励等级名称列表</param>
        /// <param name="exception"></param>
        /// <returns>查询到非空结果返回true，否则返回false</returns>
        public static bool GetRewardClass(ref List<string> nameList, ref string exception)
        {
            nameList.Add("一等奖");
            nameList.Add("二等奖");
            nameList.Add("三等奖");
            return true;
        }
    }
}
