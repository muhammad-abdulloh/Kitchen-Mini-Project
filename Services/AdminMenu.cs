using Kitchen_Mini_Project.Constants;
using Kitchen_Mini_Project.Moduls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kitchen_Mini_Project.Services
{
    public class AdminMenu
    {
        public static void Employees()
        {
            string elements = File.ReadAllText(PathConst.EmployeesDBPath);

            List<Employees> result = JsonConvert.DeserializeObject<List<Employees>>(elements);

            foreach (var employee in result)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("| id: {0, 8} | name: {1, 20} | title: {2, 40} | salary: {3, 10} RUB |",
                    employee.Id, employee.Name, employee.Title, employee.Salary);

                ForegroundColor = ConsoleColor.White;

            }

        }


    }
}
