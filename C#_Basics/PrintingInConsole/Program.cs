/* printing datatable in the console */
static void PrintDataTable(DataTable tbl)
{
    string line = "";
    foreach (DataColumn item in tbl.Columns)
    {
        line += item.ColumnName + "   ";
    }
    line += "\n";
    foreach (DataRow row in tbl.Rows)
    {
        for (int i = 0; i < tbl.Columns.Count; i++)
        {
            line += row[i].ToString() + "   ";
        }
        line += "\n";
    }
    Console.WriteLine(line);
}
PrintDataTable(dataTable2);


/* printing lines using JOIN */
Console.WriteLine(string.Join(", ", objectName()));



/* printing objects line by line */
foreach (var item in objectName)
{
    global::System.Console.WriteLine(item);
}