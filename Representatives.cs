using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace cs
{
    public delegate void reception(string receiving);
    class Employee
    {
        public string First_name { get; set; } = "Иван";
        public string Last_name { get; set; } = "Иванов";
        public void receipt(string passing)
        {
            WriteLine($"сотрудник {Last_name} {First_name} ({DateTime.Now}) принят на работу");
        }
    }
    class Employer
    {
        public event reception rec_event;
        public void technique(string passing)
        {
            if (rec_event != null) rec_event(passing);
        }
    }
    internal class Representatives
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer();
            Employee worker = new Employee();
            Employee officer = new Employee();
            Employee staff_memb = new Employee();
            employer.rec_event += worker.receipt;
            employer.rec_event += officer.receipt;
            employer.rec_event += staff_memb.receipt;
            employer.technique("прохождение приёма сотрудника на работу");
        }
    }
}