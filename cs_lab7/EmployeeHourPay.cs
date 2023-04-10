using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EmployeeHourPay:EmployeeFixPay
{
    //Поля
    public int HourCount { get; set; }

    //Конструкторы
    public EmployeeHourPay():base()
    {
        HourCount = 30;
    }
    public EmployeeHourPay(string name, string surName, DateTime dateofBirth, char sex, double salary, double premium, int hourCount):base(name, surName, dateofBirth, sex, salary, premium)
    {
        HourCount = hourCount;
    }

    //Метод ToString
    public override string ToString()
    {
        return base.ToString() + " " + HourCount;
    }

    //Метод ввода
    public void input()
    {
        base.input();
        Console.Write("Введите количество часов: ");
        HourCount = Convert.ToInt32(Console.ReadLine());
    }

    //Метод вывода
    public void output()
    {
        base.output();
        Console.WriteLine($"Количество часов: {HourCount}");
    }

    //Метод расчитывающий общий объём заработной платы
    public override double all_salary()
    {
        return base.all_salary()*HourCount;
    }
}