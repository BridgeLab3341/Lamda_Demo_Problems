using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Demo_Problems
{
    public class Model
    {
        public int S_NO { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Model(int s_no, string name, int age)
        {
            this.S_NO = s_no;
            this.Name = name;
            this.Age = age;
        }
    }
}
