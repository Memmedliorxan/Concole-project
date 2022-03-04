using Console_App.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App.interfaces
{
    interface IHumanResourceManager
    {
        Department[] Departments { get; }

        void AddDepartment(string name, int workerlimit, double salarylimit);

        void EditDepartments(string oldname, string newname);
        void AddEmployee(string fullname, string position, double salary, string departmentname);
        void RemoveEmployee(string employee, string departmentname);
        void EditEmployee(string departmentname, string employeeno, string fullname, double salary, string position);

    }
}
