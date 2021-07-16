using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ExternalProduct.Library
{
    public class ExcelReader
    {
        public List<ExternalProduct> result;
        string path = "";
        _Application excel = new Application();

        Workbook wb;
        Worksheet ws;
        public ExcelReader(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(this.path);
            ws = wb.Worksheets[sheet];
            ReadFile();
        }
        public void ReadFile()
        {
            result = new List<ExternalProduct>();
            for (int rindex = 1 ; rindex<ws.UsedRange.Rows.Count;rindex++)
            {
                ExternalProduct item = new ExternalProduct()
                {
                    Action = ReadCell(rindex, 0),
                    ExternalProductID = ReadCell(rindex, 1),
                    BusinessUnit = ReadCell(rindex, 2),
                    Culture = ReadCell(rindex, 3),
                    DocumentType = ReadCell(rindex, 4),
                    MIMEType = ReadCell(rindex, 5),
                    SourceDocumentURL = ReadCell(rindex, 6),
                    Brand = ReadCell(rindex, 6),
                    DocumentTitle = ReadCell(rindex, 7),
                };
                if (item.ExternalProductID !="")
                    result.Add(item);
            }
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)ws.Cells[i, j];
            if (range.Value2 != null)
                return range.Value2;
            else
                return "";
        }
    }
}
