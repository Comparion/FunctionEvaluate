using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionEvaluate
{
    class Program
    {
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Evaluate("9 + 5 * 4 /2 -2 +10 *2"));
            Console.ReadKey();
        }
    }
}
