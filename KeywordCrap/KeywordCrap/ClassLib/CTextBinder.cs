using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace KeywordCrap.ClassLib
{
    class CTextBinder
    {
        public string FilePath;

        public DataTable Bind()
        {
            // Create new DataTable.

            DataTable table = new DataTable();
            DataRow row;
            string FILENAME = FilePath;
            DataColumn column;
            string line;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Site";
            table.Columns.Add(column);

            if (File.Exists(FILENAME))
            {
                StreamReader objStreamReader;
                objStreamReader = File.OpenText(FILENAME);

                while ((line = objStreamReader.ReadLine()) != null)
                {
                    row = table.NewRow();
                    row["Site"] = line;
                    table.Rows.Add(row);
                }
                objStreamReader.Close();            
            }
            return table;
        }

        public void Flush(DataTable dt)
        {
            string FILENAME = FilePath;
            StreamWriter objStreamWriter;
            objStreamWriter = File.CreateText(FILENAME);

            foreach (DataRow dr in dt.Rows)
            {
                objStreamWriter.WriteLine(dr[0].ToString());
            }
            objStreamWriter.Close();
        }
    }
}
