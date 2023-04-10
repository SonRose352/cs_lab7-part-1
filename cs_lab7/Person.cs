using cs_lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person:ICliable
{
    //Поля
    public string Name { get; set; }
    public string SurName { get; set; }
    public DateTime DateofBirth { get; set; }
    private char sex;
    public char Sex
    {
        get { return sex; }
        set
        {
            if (value == 'f' || value == 'm')
                sex = value;
        }
    }

    //Конструкторы
    public Person()
    {
        Name = "Niyaz";
        SurName = "Tukhbatullin";
        DateofBirth = new DateTime(2004, 9, 20);
        sex = 'm';
    }
    public Person(string name, string surName, DateTime dateofBirth, char sex)
    {
        Name = name;
        SurName = surName;
        DateofBirth = dateofBirth;
        this.sex = sex;
    }
    public Person(Person person)
    {
        Name = person.Name;
        SurName = person.SurName;
        DateofBirth = person.DateofBirth;
        this.sex = person.sex;
    }

    //Методы для консольного ввода и вывода
    public void input()
    {
        Console.Write("Введите Имя: ");
        Name = Console.ReadLine();
        Console.Write("Введите Фамилию: ");
        SurName = Console.ReadLine();
        Console.Write("Введите Дату рождения: ");
        DateofBirth = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Введите пол: ");
        sex = Convert.ToChar(Console.ReadLine());
    }
    public void output()
    {
        Console.WriteLine($"Фамилия: {SurName}\nИмя: {Name}\nДата рождения: {DateofBirth}\nПол: {sex}");
    }

    //Метод ToString
    public override string ToString()
    {
        return SurName + " " + Name + " " + DateofBirth + " " + sex;
    }

    //Метод, возвращающий количество полных лет
    public int age()
    {
        var age = DateTime.Now.Year - DateofBirth.Year;
        if (DateTime.Now.DayOfYear < DateofBirth.DayOfYear)
            age--;
        return age;
    }
}