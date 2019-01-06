using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
 public   class Test
    {
        public string test_Id { get=>tester_Id; private set=>tester_Id=value; }
        public string tester_Id { get=>tester_Id; private set=>tester_Id=value; }
        public string student_Id { get=>student_Id ; private set=> student_Id=value; }
        public DateTime test_date { get=> test_date; private set => test_date= value; }
        public DateTime test_time { get =>test_time ; private set=>test_time=value; }
        public Adress test_address { get=>test_address; private set=>test_address=value; }
        public bool distance_keep { get=>distance_keep; private set =>distance_keep=value; }
        public bool reverse_parking { get; private set; }
        public bool mirrors { get=>mirrors; private set=>mirrors=value; }
        public bool signals { get=>signals; private set=>signals=value; } //aitutim
        public bool speed { get => speed; private set => speed = value; }
        public bool is_pass { get=>is_pass; private set=>is_pass=value; }
        public string tester_note { get=>tester_note; private set=> tester_note=value; }
        public Gear_type gearBox { get => gearBox; set => gearBox = value; }
        public Vehicle car { get => car; set => car = value; }

        public Test(string testerId, string studentId, DateTime date, Adress address, Gear_type gearBox, Vehicle car)

        {
            this.tester_Id = testerId;
            this.student_Id = studentId;
            this.test_date = date;
            this.test_address = address;
            this.gearBox = gearBox;
            this.car = car;

        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
