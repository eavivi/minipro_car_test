using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Tester
    {
       public int id { get; private set; }
       public string first_name { get; private set; }
       public string last_name { get; private set; }
       public DateTime date_birth { get; private set; }
       public Gender g { get; private set; }
       public int phone { get; private set; }
       public Adress adress { get; private set; }
       public int experience { get; private set; }
       public int max_test { get; private set; }
       public Vehicle vehicle { get; private set; }
       public bool[,] work_range = new bool[5, 6] ;
       public double max_distance { get; private set; }
       public override string ToString()
        {
            return base.ToString();
        }


    }
}
