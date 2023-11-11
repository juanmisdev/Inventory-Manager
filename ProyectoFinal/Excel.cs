using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using System.Data;
using System.Collections;

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

            //Titulo:
            // Define the cell range you want to combine
            Excel.Excel.Range titulo_productos = worksheet.Cells[1, 1];
            titulo_productos.Value = "Productos";
            titulo_productos.Font.Bold = true;
            titulo_productos.Font.Size = 14;
            titulo_productos.HorizontalAlignment = Excel.Excel.XlHAlign.xlHAlignCenter;

            Excel.Excel.Range cellRange = worksheet.get_Range("A1:F1"); // Adjust the range as needed
            cellRange.Merge();

            // Write the column headers to the Excel file
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                worksheet.Cells[2, i + 1] = dataTable.Columns[i].ColumnName;
            }

            // Write the data rows to the Excel file
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    worksheet.Cells[row + 3, col + 1] = dataTable.Rows[row][col];
                }
            }

            int ultimo_row = dataTable.Rows.Count + 5;
            //Aplico un grid:
            Excel.Excel.Range rango_productos = worksheet.get_Range($"A1:F{ultimo_row - 3}");
            rango_productos.Borders.LineStyle = Excel.Excel.XlLineStyle.xlContinuous;

            List<int> id_productos = new List<int>();
            List<int> cantidad_producto = new List<int>();
            //Obtengo el id de todos los productos en datatable y su cantidad

            for(int row = 0; row < dataTable.Rows.Count; row ++)
            {
                int id = Convert.ToInt32(dataTable.Rows[row]["id"]);
                id_productos.Add(id);

                int cantidad_ = Convert.ToInt32(dataTable.Rows[row]["cantidad"]);
                cantidad_producto.Add(cantidad_);
            }

            //Ahora exportamos todos los accesorios necesarios:

            DataTable tabla_accesorios = new DataTable();
            tabla_accesorios = Producto.AccesoriosDeUnaLista(id_productos, cantidad_producto, tabla_accesorios);

            // Titulo accesorios:
            Excel.Excel.Range titulo_accesorios = worksheet.Cells[ultimo_row - 1, 1];
            titulo_accesorios.Value = "Accesorios";
            titulo_accesorios.Font.Bold = true;
            titulo_accesorios.Font.Size = 14;
            titulo_accesorios.HorizontalAlignment = Excel.Excel.XlHAlign.xlHAlignCenter;

            Excel.Excel.Range cellRange1 = worksheet.get_Range($"A{ultimo_row - 1}:F{ultimo_row - 1}"); 
            cellRange1.Merge();

            // Write the column headers to the Excel file
            for (int i = 0; i < tabla_accesorios.Columns.Count; i++)
            {
                worksheet.Cells[ultimo_row, i + 1] = tabla_accesorios.Columns[i].ColumnName;
            }

            // Write the data rows to the Excel file
            for (int row = 0; row < tabla_accesorios.Rows.Count; row++)
            {
                for (int col = 0; col < tabla_accesorios.Columns.Count; col++)
                {
                    worksheet.Cells[ultimo_row + row + 1, col + 1] = tabla_accesorios.Rows[row][col];
                }
            }

            int ultimo_row2 = tabla_accesorios.Rows.Count;
            //Aplico un grid:
            Excel.Excel.Range rango_accesorios = worksheet.get_Range($"A{ultimo_row - 1}:F{ultimo_row + ultimo_row2}");
            rango_accesorios.Borders.LineStyle = Excel.Excel.XlLineStyle.xlContinuous;

            Marshal.ReleaseComObject(workbook);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
    }

}
