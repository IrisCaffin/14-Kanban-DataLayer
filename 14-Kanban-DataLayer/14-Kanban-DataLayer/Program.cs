using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Kanban_DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new KanbanPart1Entities())
            {
                //var List = db.Lists.First();
                foreach (var List in db.Lists)
                {
                    Console.WriteLine(List.Name);

                    foreach (var cards in List.Cards)
                    {
                        Console.WriteLine("\t" + cards.Text);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
