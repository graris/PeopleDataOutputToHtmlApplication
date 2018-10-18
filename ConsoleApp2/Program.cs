using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.NewDb;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new PeopleContext())
            {
                Repository<Person> peopleRep = new Repository<Person>(db);

                var people = peopleRep.List();

                ListDataToHtmlWriter dataToHtmlWr = new ListDataToHtmlWriter("people_sortedByFirstName.html", "People (sorted by first name A-Z)", people.OrderBy(o => o.FirstName).ToList());
                dataToHtmlWr.outputAllDataToHtmlFile();

                dataToHtmlWr.HtmlFileName = "people_sortedBySecondName.html";
                dataToHtmlWr.DataHeader = "People (sorted by second name A-Z)";
                dataToHtmlWr.DataList = people.OrderBy(o => o.LastName).ToList();
                dataToHtmlWr.outputAllDataToHtmlFile();
            }
            Console.ReadKey();
        }

    }
}
