using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Trainee //student for test
    {
        
        public int id { get; private set; }
        public string first_name { get; private set; }
        public string last_name { get; private set; }
        public DateTime date_birth { get; private set; }
        public Gender g { get; private set; }
        public int phone { get; private set; }
        public Adress adress { get; private set; }
        public Vehicle vehicle { get; private set; }
        public Gear_type g_t { get; private set; }
        public string school { get; private set; }
        public string teacher { get; private set; }
        public int lesson_Num { get; private set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
