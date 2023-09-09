using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DailyDataFormat
{
    public class Program
    {
        public static string filedate;
        public static List<string> StockList;
        public static List<string> SkipList;

        public static List<string> Notfounddata = new List<string>();
        public static List<Datamodel> Newdata = new List<Datamodel>();

        public static void Main(string[] args)
        {
            StockList = File.ReadAllLines("sample.txt")
                                            .Select(v => getStockList(v))
                                            .ToList();
            SkipList = File.ReadAllLines("skiplist.txt")
                                            .Select(v => getStockList(v))
                                            .ToList();

            DirectoryInfo d = new DirectoryInfo(@".\");
            FileInfo[] Files = d.GetFiles("*.csv");
           
            foreach (FileInfo file in Files)
            {
                List<Datamodel> Stockdata = File.ReadAllLines(file.Name)
                                           .Skip(1)
                                           .Select(v => getNsedata(v))
                                           .ToList();
                Stockdata = RemoveDuplicate(Stockdata);
                foreach (string stock in StockList)
                {
                    if (!Stockdata.Any(r => r.Name == stock))
                    {
                        Notfounddata.Add(stock);
                    }
                }

                if (!Directory.Exists("Output"))
                {
                    Directory.CreateDirectory("Output");
                    Directory.CreateDirectory("temp");
                }
                

                var lines = new List<string>();
                var valueLines = Stockdata.Where(row => row.Name != null).Select(row => string.Join(",", new string[] { row.Name, row.dateDate, row.Open, row.High, row.Low, row.Close, row.Volume }));
                lines.AddRange(valueLines);
                File.WriteAllLines("Output\\" + filedate + "-NSE-EQ-F.txt", lines.ToArray());

                var linesN = new List<string>();
                var valueLinesN = Newdata.Where(row => row.Name != null).Select(row => string.Join(",", new string[] { row.Name, row.dateDate, row.Open, row.High, row.Low, row.Close, row.Volume }));
                linesN.AddRange(valueLinesN);
                if (Newdata.Count > 0)
                {
                    Console.WriteLine("New stock found...................");
                    Console.WriteLine(string.Join("\n", linesN));
                    Console.WriteLine("Press 1 for add into Sample, 2 for skiplist, 3 for ignore :- ");
                    string input = Console.ReadLine();
                    if (input=="1")
                    {
                        File.AppendAllLines("sample.txt", linesN.ToArray());
                    }
                    else if (input == "2")
                    {
                        File.AppendAllLines("skiplist.txt", linesN.ToArray());
                    }
                    else
                    {
                        File.WriteAllLines("temp\\" + filedate + "-New-Stock.txt", linesN.ToArray());
                    }
                                       
                    
                    StockList = File.ReadAllLines("sample.txt")
                                            .Select(v => getStockList(v))
                                            .ToList();
                    SkipList = File.ReadAllLines("skiplist.txt")
                                            .Select(v => getStockList(v))
                                            .ToList();
                }
                if (Notfounddata.Count > 0)
                {
                    File.WriteAllLines("temp\\" + filedate + "-NotFound-Stock.txt", Notfounddata.ToArray());
                }
                Newdata = new List<Datamodel>();
                Notfounddata = new List<string>();
            }


            Files = d.GetFiles("*NSE-EQ.txt");
            foreach (FileInfo file in Files)
            {
                List<Datamodel> Stockdata = File.ReadAllLines(file.Name)
                                           .Select(v => getBavecopydata(v))
                                           .ToList();

                Stockdata = RemoveDuplicate(Stockdata);

                foreach (string stock in StockList)
                {
                    if (!Stockdata.Any(r => r.Name == stock))
                    {
                        Notfounddata.Add(stock);
                    }
                }


                var lines = new List<string>();
                var valueLines = Stockdata.Where(row => row.Name != null).Select(row => string.Join(",", new string[] { row.Name, row.dateDate, row.Open, row.High, row.Low, row.Close, row.Volume }));
                lines.AddRange(valueLines);
                File.WriteAllLines("Output\\" + filedate + "-NSE-EQ-F.txt", lines.ToArray());

                var linesN = new List<string>();
                var valueLinesN = Newdata.Where(row => row.Name != null).Select(row => string.Join(",", new string[] { row.Name, row.dateDate, row.Open, row.High, row.Low, row.Close, row.Volume }));
                linesN.AddRange(valueLinesN);
                if (Newdata.Count > 0)
                {
                    Console.WriteLine("New stock found...................");
                    Console.WriteLine(string.Join("\n", linesN));
                    Console.WriteLine("Press 1 for add into Sample, 2 for skiplist, 3 for ignore :- ");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        File.AppendAllLines("sample.txt", linesN.ToArray());
                    }
                    else if (input == "2")
                    {
                        File.AppendAllLines("skiplist.txt", linesN.ToArray());
                    }
                    else
                    {
                        File.WriteAllLines("temp\\" + filedate + "-New-Stock.txt", linesN.ToArray());
                    }


                    StockList = File.ReadAllLines("sample.txt")
                                            .Select(v => getStockList(v))
                                            .ToList();
                    SkipList = File.ReadAllLines("skiplist.txt")
                                            .Select(v => getStockList(v))
                                            .ToList();
                }
                if (Notfounddata.Count > 0)
                {
                    File.WriteAllLines("temp\\" + filedate + "-NotFound-Stock.txt", Notfounddata.ToArray());
                }
                Newdata = new List<Datamodel>();
                Notfounddata = new List<string>();
            }

            Console.WriteLine("All done enter for exit...................");
            Console.ReadLine();
        }


        public static string getStockList(string csvLine)
        {
            string[] values = csvLine.Split(',');
            return values[0];
        }

        public static Datamodel getNsedata(string csvLine)
        {
            if (!string.IsNullOrEmpty(csvLine))
            {
                Datamodel data = new Datamodel();
                string[] values = csvLine.Split(',');
                data.Name = values[0];
                DateTime date_Date = Convert.ToDateTime(values[10]);
                filedate = date_Date.ToString("yyyy-MM-dd");
                data.dateDate = date_Date.ToString("yyyyMMdd");
                data.Open = values[2];
                data.High = values[3];
                data.Low = values[4];
                data.Close = values[5];
                data.Volume = values[8];
                if (StockList.Contains(values[0]))
                {
                    return data;
                }
                else
                {
                    if (!SkipList.Contains(values[0]))
                    {
                        Newdata.Add(data);
                    }
                    
                    return new Datamodel();
                }
            }

            return new Datamodel();

        }

        public static Datamodel getBavecopydata(string csvLine)
        {
            if (!string.IsNullOrEmpty(csvLine))
            {
                Datamodel data = new Datamodel();
                string[] values = csvLine.Split(',');
                data.Name = values[0];
                filedate = values[1].Substring(0, 4) + "-" + values[1].Substring(4, 2) + "-" + values[1].Substring(6, 2);
                data.dateDate = values[1];
                data.Open = values[2];
                data.High = values[3];
                data.Low = values[4];
                data.Close = values[5];
                data.Volume = values[6];
                if (StockList.Contains(values[0]))
                {
                    return data;
                }
                else
                {
                    if (!SkipList.Contains(values[0]))
                    {
                        Newdata.Add(data);
                    }                   
                    return new Datamodel();
                }
            }
            return new Datamodel();

        }

        public static List<Datamodel> RemoveDuplicate(List<Datamodel> Stockdata)
        {
            List<Datamodel> newStockdata = new List<Datamodel>();
            List<string> Stocks = new List<string>();

            foreach (Datamodel stdt in Stockdata)
            {
                if (!Stocks.Contains(stdt.Name))
                {
                    Stocks.Add(stdt.Name);
                    newStockdata.Add(stdt);
                }
            }

            return newStockdata;
        }

    }
}
