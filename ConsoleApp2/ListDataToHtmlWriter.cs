using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.NewDb;

namespace ConsoleApp2
{
    class ListDataToHtmlWriter
    {
        string htmlFileName;
        string dataHeader = "";
        IEnumerable<Object> dataList;

        public string HtmlFileName
        {
            get => htmlFileName;
            set => htmlFileName = value;
        }
        public string DataHeader
        {
            get => dataHeader;
            set => dataHeader = value;
        }
        public IEnumerable<object> DataList
        {
            get => dataList;
            set => dataList = value;
        }

        public ListDataToHtmlWriter(string htmlFileName, string dataHeader, IEnumerable<Object> dataList)
        {
            HtmlFileName = htmlFileName;
            DataHeader = dataHeader;
            DataList = dataList;
        }

        public ListDataToHtmlWriter() { }
        
        public void outputAllDataToHtmlFile()
        {
            if ((htmlFileName == null)||(htmlFileName == ""))
                throw new FileNotFoundException();

            using (FileStream fs = new FileStream(HtmlFileName, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<h1>" + DataHeader + "</h1>");
                    outputAllDataInHtml(w, DataList);
                    Console.WriteLine("Done writing to {0} file!", HtmlFileName);
                }
            }
        }

        private void outputAllDataInHtml(StreamWriter w, IEnumerable<Object> dataList)
        {

            foreach (Person dataUnit in dataList)
            {
                w.WriteLine("<p>" + dataUnit.ToString() + "</p>");
            }
        }
    }
}
