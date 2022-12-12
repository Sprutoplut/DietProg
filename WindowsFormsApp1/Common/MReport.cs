using ESRI.ArcGIS.Geodatabase;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Common
{
    public static class MReport
    {
        #region Word        
        public static Document Word_Begin(Microsoft.Office.Interop.Word.Application wordApp)
        {
            {
                wordApp.Documents.Add();
                return wordApp.ActiveDocument;
            }
        }
        public static void Word_Title(Microsoft.Office.Interop.Word.Application wordApp, string title, int fontSize, WdParagraphAlignment alignAfter)
        {
            {
                Selection sel = wordApp.Selection;
                sel.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                sel.Font.Size = fontSize;
                sel.Font.Bold = 1;
                sel.TypeText(Text: title);

                sel.TypeParagraph();
                sel.Font.Size = 12;
                sel.Font.Bold = 0;
                sel.ParagraphFormat.Alignment = alignAfter;
            }
        }
        public static void Word_Absaz(Microsoft.Office.Interop.Word.Application wordApp, string txt)
        {
            {
                Selection sel = wordApp.Selection;
                sel.TypeText(Text: txt);
                sel.TypeParagraph();
            }
        }
        public static void Word_TextLine(Microsoft.Office.Interop.Word.Range wordRange, string txt)
        {
            {
                wordRange.InsertAfter(txt);
                wordRange.InsertParagraphAfter();
            }
        }
        public static void Word_Text(Microsoft.Office.Interop.Word.Application wordApp, string txt)
        {
            {
                Selection sel = wordApp.Selection;
                sel.TypeText(Text: txt);
            }
        }
        public static void Word_Image(Microsoft.Office.Interop.Word.Application wordApp, System.Drawing.Bitmap Image)
        {
            System.Windows.Forms.Clipboard.SetImage(Image);
            Selection sel = wordApp.Selection;
            sel.Range.Paste();
            sel.Move(4, 2000000);
        }
        public static void Word_TableTitle(Microsoft.Office.Interop.Word.Range wordRange, IRow r)
        {
            string aliasField;
            string row = "№";

            for (int i = 2; i <= r.Fields.FieldCount - 1; i++)
            {
                aliasField = r.Fields.Field[i].AliasName;
                if (aliasField == "SHAPE_Length") aliasField = "Периметр (м)";
                if (aliasField == "SHAPE_Area") aliasField = "Площадь (м2)";
                row = row + '^' + aliasField;
            }
            wordRange.InsertAfter(row);
            wordRange.InsertParagraphAfter();
        }
        public static void Word_TableRow(Microsoft.Office.Interop.Word.Range wordRange, IRow r)
        {
            string valueField;
            string row = r.OID.ToString();

            for (int i = 2; i <= r.Fields.FieldCount - 1; i++)
            {
                try
                {
                    if (r.Fields.Field[i].Type == esriFieldType.esriFieldTypeDouble |
                        r.Fields.Field[i].Type == esriFieldType.esriFieldTypeInteger |
                        r.Fields.Field[i].Type == esriFieldType.esriFieldTypeSingle |
                        r.Fields.Field[i].Type == esriFieldType.esriFieldTypeSmallInteger)
                        valueField = FNumber(r.Value[i]);
                    else
                        valueField = r.Value[i].ToString();
                }
                catch (Exception)
                {
                    valueField = "";
                }
                row = row + '^' + valueField;
            }
            wordRange.InsertAfter(row);
            wordRange.InsertParagraphAfter();

        }
        public static void Word_ArrayRow(Microsoft.Office.Interop.Word.Range wordRange, object[] arr)
        {
            string valueField;
            string row = "";
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    valueField  = arr[i].ToString();
                }
                catch (Exception)
                {
                    valueField = "";
                }
                if (row == "")
                    row = valueField;
                else
                    row = row + '^' + valueField;
            }
            wordRange.InsertAfter(row);
            wordRange.InsertParagraphAfter();

        }
        public static void Word_PageBreak(Microsoft.Office.Interop.Word.Application objWord, Document objDoc)
        {
            Paragraph para = objDoc.Paragraphs.Add();
            para.Range.InsertBreak();
            objDoc.Sections.Add();
            objWord.Selection.GoTo(10, 2);
        }
        #endregion

        #region Excel
        public static Worksheet Excel_Begin(Microsoft.Office.Interop.Excel.Application excelApp, string labelSheet)
        {
            Workbook book = excelApp.Workbooks.Add();
            Worksheet sheet = book.Worksheets.Add();
            sheet.Name = labelSheet;
            return sheet;
        }
        public static Workbook Excel_NewBook(Microsoft.Office.Interop.Excel.Application excelApp)
        {
            return excelApp.Workbooks.Add();
        }
        public static void Excel_Title(Worksheet excelSheet, string title, int fontSize, int row, int col)
        {
            excelSheet.Cells[row, col].Value = title;
            excelSheet.Cells[row, col].Font.Size = fontSize;
            excelSheet.Cells[row, col].Font.Bold = true;
        }
        public static void Excel_CoupleData(Worksheet excelSheet, ref int row, string sName, object value)
        {
            excelSheet.Cells[row, 1].Value = sName;
            excelSheet.Cells[row, 2].Value = value;
            row = row + 1;
        }

        public static void Excel_CoupleDataValue(Worksheet excelSheet, ref int row, object sName, object value)
        {
            excelSheet.Cells[row, 1].Value = sName;
            excelSheet.Cells[row, 2].Value = value;
            row = row + 1;
        }
        public static void Excel_TrioData(Worksheet excelSheet, ref int row, string sName, object value, string sMeasure)
        {
            excelSheet.Cells[row, 1].Value = sName;
            excelSheet.Cells[row, 2].Value = value;
            excelSheet.Cells[row, 3].Value = sMeasure;
            row = row + 1;
        }
        public static void Excel_FourData(Worksheet excelSheet, ref int row, string sName, object var1, object var2, object var3)
        {
            excelSheet.Cells[row, 1].Value = sName;
            excelSheet.Cells[row, 2].Value = var1;
            excelSheet.Cells[row, 3].Value = var2;
            excelSheet.Cells[row, 4].Value = var3;
            row = row + 1;
        }
        public static void Excel_SixData(Worksheet excelSheet, ref int row, string sName, object var1, object var2, object var3, object var4, object var5)
        {
            excelSheet.Cells[row, 1].Value = sName;
            excelSheet.Cells[row, 2].Value = var1;
            excelSheet.Cells[row, 3].Value = var2;
            excelSheet.Cells[row, 4].Value = var3;
            excelSheet.Cells[row, 5].Value = var4;
            excelSheet.Cells[row, 6].Value = var5;
            row = row + 1;
        }
        public static void Excel_TrioDataValue(Worksheet excelSheet, ref int row, int sName, string value, object sMeasure)
        {
            excelSheet.Cells[row, 1].Value = sName;
            excelSheet.Cells[row, 2].Value = value;
            excelSheet.Cells[row, 3].Value = sMeasure;
            row = row + 1;
        }

        public static void Excel_TrioColor(Worksheet excelSheet, int rowBegin, int rowEnd, int color)
        {
            for (int i = rowBegin; i <= rowEnd; i++)
            {
                excelSheet.Cells[i, 1].Interior.Color = color;
                excelSheet.Cells[i, 1].Borders.LineStyle = 1;
                excelSheet.Cells[i, 2].Interior.Color = color;
                excelSheet.Cells[i, 2].Borders.LineStyle = 1;
                excelSheet.Cells[i, 3].Interior.Color = color;
                excelSheet.Cells[i, 3].Borders.LineStyle = 1;
            }
        }
        public static void Excel_GroupData(Worksheet excelSheet, ref int row, object[] group)
        {
            for (int i = 1; i <= group.Length; i++)
                excelSheet.Cells[row, i].Value = group[i - 1];
            row = row + 1;
        }
        public static void Excel_GroupColor(Worksheet excelSheet, int rowBegin, int rowEnd, int color, int groupLength)
        {
            for (int i = rowBegin; i <= rowEnd; i++)
            {
                for (int j = 1; j <= groupLength; j++)
                {
                    excelSheet.Cells[i, j].Interior.Color = color;
                    excelSheet.Cells[i, j].Borders.LineStyle = 1;
                }
            }
        }
        public static void Excel_TableTitle(Worksheet excelSheet, IRow r)
        {
            string aliasField;
            excelSheet.Cells[1, 1].Value = "№";

            for (int i = 2; i <= r.Fields.FieldCount - 1; i++)
            {
                aliasField = r.Fields.Field[i].AliasName;
                if (aliasField == "SHAPE_Length") aliasField = "Периметр, м";
                if (aliasField == "SHAPE_Area") aliasField = "Площадь, м2";

                excelSheet.Cells[1, i].Value = aliasField;
            }
        }
        public static void Excel_TableRow(Worksheet excelSheet, IRow r, int index)
        {
            excelSheet.Cells[index, 1].Value = r.OID;

            for (int i = 2; i <= r.Fields.FieldCount - 1; i++)
            {
                try
                {
                    excelSheet.Cells[index, i].Value = r.Value[i];
                }
                catch (Exception)
                {
                }
            }
        }
        public static void Excel_ArrayRow(Worksheet excelSheet, object[] arr, int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    excelSheet.Cells[index, i + 1].Value = arr[i];
                }
                catch (Exception)
                {
                }
            }
        }
        #endregion

        #region текстовый файл        
        public static string Text_GetTempFile()
        {
            string txtFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName());
            return System.IO.Path.ChangeExtension(txtFile, "txt");
        }
        public static void Text_OpenFile(string txtFile)
        {
            Process myProcess = new Process();
            try
            {
                if (!System.IO.File.Exists(txtFile)) return;
                myProcess.StartInfo.FileName = txtFile;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch (Exception)
            {
            }
        }
        public static void Text_TableTitle(StreamWriter sw, IRow r)
        {
            string aliasField;
            string row = "№";

            for (int i = 2; i <= r.Fields.FieldCount - 1; i++)
            {
                aliasField = r.Fields.Field[i].AliasName;
                if (aliasField == "SHAPE_Length") aliasField = "Периметр (м)";
                if (aliasField == "SHAPE_Area") aliasField = "Площадь (м2)";
                row = row + '\t' + aliasField;
            }
            sw.WriteLine(row);
        }
        public static void Text_TableRow(StreamWriter sw, IRow r)
        {
            string valueField;
            string row = r.OID.ToString();

            for (int i = 2; i <= r.Fields.FieldCount - 1; i++)
            {
                try
                {
                    if (r.Fields.Field[i].Type == esriFieldType.esriFieldTypeDouble |
                        r.Fields.Field[i].Type == esriFieldType.esriFieldTypeInteger |
                        r.Fields.Field[i].Type == esriFieldType.esriFieldTypeSingle |
                        r.Fields.Field[i].Type == esriFieldType.esriFieldTypeSmallInteger)
                        valueField = FNumber(r.Value[i]);
                    else
                        valueField = r.Value[i].ToString();
                }
                catch (Exception)
                {
                    valueField = "";
                }
                row = row + '\t' + valueField;
            }
            sw.WriteLine(row);
        }
        #endregion

        #region графический файл        
        public static string Image_GetTempFilePNG()
        {
            string txtFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName());
            return System.IO.Path.ChangeExtension(txtFile, "png");
        }
        public static void Image_OpenFile(string imageFile)
        {
            Process myProcess = new Process();
            try
            {
                if (!System.IO.File.Exists(imageFile)) return;
                myProcess.StartInfo.FileName = imageFile;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch (Exception)
            {
            }
        }

        #endregion

        #region форматирование
        public static string FNumber(object vv)
        {
            if (vv == null) return "не определяется";

            double v = Convert.ToDouble(vv);
            if (Math.Abs(v) > 1000) return v.ToString("N0");
            if (Math.Abs(v) > 100) return v.ToString("N1");
            if (Math.Abs(v) > 10) return v.ToString("N2");
            if (Math.Abs(v) > 1) return v.ToString("N3");
            if (Math.Abs(v) < 0.0001)
                return v.ToString("E");
            else
                return v.ToString("N4");
        }

        public static string FLogical(object v)
        {
            if (v.ToString().ToUpper() == "TRUE")
                return "да";
            else
                return "нет";
        }
        #endregion
    }
}
