using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App.models 
{

    class Employee
    {
        private static int _count = 1000;
        public readonly string No;

        public string FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string DepartmentName { get; set; }


        public Employee(string No, string fullname, string position, int salary, string departmentname)
        {
            FullName = FullName;
            Position = Position;
            Salary = Salary;
            DepartmentName = DepartmentName;
        }

        public override string ToString()
        {
            return $"Ad Soyad: {FullName}" +
                $"\nVezifesi: {Position}" +
                $"\nMaas: {Salary}" +
                $"\nDepartament Adi: {DepartmentName}";
        }





    }
}
