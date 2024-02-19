using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Выберите документ");
                string format = Console.ReadLine();
                switch (format.ToLower())
                {
                    case "xml":
                        List<AbstractHandler> xml1 = new List<AbstractHandler>();
                        xml1.Add(new XMLHandler());
                        foreach (var elem in xml1)
                        {
                            elem.Open();
                            elem.Create();
                            elem.Change();
                            elem.Save();

                        }
                        break;
                    case "txt":
                        List<AbstractHandler> txt1 = new List<AbstractHandler>();
                        txt1.Add(new TXTHandler());
                        foreach (var elem in txt1)
                        {
                            elem.Open();
                            elem.Create();
                            elem.Change();
                            elem.Save();

                        }
                        break;
                    case "doc":
                        List<AbstractHandler> doc1 = new List<AbstractHandler>();
                        doc1.Add(new DOCHandler());
                        foreach (var elem in doc1)
                        {
                            elem.Open();
                            elem.Create();
                            elem.Change();
                            elem.Save();

                        }
                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("Такого формата нет");
                        break;



                }
                Console.ReadKey();
            }
           

        }
    }
}
