using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class EmployeeFixPay:Person
{
    //Поля
    public double Salary { get; set; }
    public double Premium { get; set; }

    //Конструкторы
    public EmployeeFixPay():base()
    {
        Salary = 20000;
        Premium = 20;
    }
    public EmployeeFixPay(string name, string surName, DateTime dateofBirth, char sex, double salary, double premium):base(name, surName, dateofBirth, sex)
    {
        Salary = salary;
        Premium = premium;
    }

    //Метод ToString
    public override string ToString()
    {
        return base.ToString() + " " + Salary + " " + Premium;
    }

    //Метод ввода
    public void input()
    {
        base.input();
        Console.Write("Введите оклад работника: ");
        Salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите премию работника: ");
        Premium = Convert.ToDouble(Console.ReadLine());
    }

    //Метод вывода
    public void output()
    {
        base.output();
        Console.WriteLine($"Оклад: {Salary}\nПремия: {Premium}");
    }

    //Метод рассчитывающий общий объём заработной платы с учётом премии
    public virtual double all_salary()
    {
        return Salary + Salary * Premium / 100;
    }

    //Метод рассчитывающий сумму подоходного налога
    public double tax()
    {
        return all_salary() * 0.13;
    }

    //Метод рассчитывающий сумму выдаваемую на руки
    public double actual_salary()
    {
        return all_salary() - tax();
    }
}