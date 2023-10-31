using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using System.Data;

namespace ProyectoFinal
{
    public class ExcelConexion
    {
        public static void ExportDataTableToExcel(DataTable dataTable)
        {
            Excel.Excel.Application excelApp = new Excel.Excel.Application();
            excelApp.Visible = true;

            Excel.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Excel.Worksheet worksheet = (Excel.Excel.Worksheet)workbook.Sheets[1];

            // Write the column headers to the Excel file
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }

            // Write the data rows to the Excel file
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    worksheet.Cells[row + 2, col + 1] = dataTable.Rows[row][col];
                }
            }

            Marshal.ReleaseComObject(workbook);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
    }

}
