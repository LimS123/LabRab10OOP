using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab10 { }
class Program
{

    static void Main(string[] args)
    {

        ArrayList objectList = new ArrayList() {"Диван", "Кровать", "Стол", "Стул" };

        object obj = "Люстра";

        objectList.Add(obj);
        objectList.RemoveAt(2);
        foreach (object o in objectList)
        {
            Console.WriteLine(o);
        }
        Console.WriteLine();

        foreach (object o in objectList)
        {
            if (o == "Диван")
            {
                Console.WriteLine(o);
            }
        }
        Console.WriteLine();

        HashSet<long> hash = new HashSet<long> { };
        hash.Add(1);
        hash.Add(2);
        hash.Add(3);
        hash.Add(4);
        hash.Add(5);
        hash.Add(6);
        hash.Add(7);
        hash.Add(8);
        hash.Add(9);
        //a
        foreach (var i in hash)
        {
            Console.WriteLine(i);
        }
        //b
        Console.WriteLine();
        HashSet<long> setNumbers = new HashSet<long>();
        for (int i = 1; i < 4; i++)
        {
            setNumbers.Add(i);
        }
        hash.ExceptWith(setNumbers);
        foreach (var i in hash)
        {
            Console.WriteLine(i);
        }
        //c
        LinkedList<long> LinkList = new LinkedList<long> { };
        foreach (var i in hash)
        {
            LinkList.AddFirst(i);
        }
        //d
        Console.WriteLine();
        foreach (var i in LinkList)
        {
            Console.WriteLine(i);
            if (i == 6)
            {
                Console.WriteLine($"В этом списке есть элемент со значением 6");
            }
        }


        IntelligentCreature autobus = new Transformer(10000, "punk", 100);
        IntelligentCreature train = new Transformer(1000000, "punk", 2000);
        IntelligentCreature Max = new Human(10, "punk");
        IntelligentCreature Vlados = new Human(1800, "punk");
        IntelligentCreature Roman = new Human(1930, "розовый");
        IntelligentCreature Bumbulbee = new Transformer(5123, "желтый", 10);

        HashSet<IntelligentCreature> newHash = new HashSet<IntelligentCreature> { };
        newHash.Add(autobus);
        newHash.Add(train);
        newHash.Add(Max);
        newHash.Add(Vlados);
        newHash.Add(Roman);
        newHash.Add(Bumbulbee);

        foreach (var i in newHash)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        HashSet<IntelligentCreature> setObject = new HashSet<IntelligentCreature>();
        int e = 0;
        foreach (var i in newHash)
        {
            e++;
            if (e > 2)
            {
                setObject.Add(i);
            }

        }
        hash.ExceptWith(setNumbers);
        foreach (var i in newHash)
        {
            Console.WriteLine(i);
        }

        LinkedList<IntelligentCreature> List = new LinkedList<IntelligentCreature> { };
        foreach (var i in newHash)
        {
            List.AddFirst(i);
        }
        //e
        Console.WriteLine();
        foreach (var i in List)
        {
            Console.WriteLine(i);
            if (i == Max)
            {
                Console.WriteLine("Найден объект с именем Max");
            }
        }

        ObservableCollection<IntelligentCreature> students = new ObservableCollection<IntelligentCreature>();
        students.CollectionChanged += Deal;
        for (int i = 1; i < 5; i++)
        {
            students.Add(new Human(Convert.ToInt32(i * 100 - 23 * i), "red"));
        }
        students.RemoveAt(1);
        Console.WriteLine();

        Console.Read();
    }
    private static void Deal(object a, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                {
                    Human newHuman = e.NewItems[0] as Human;
                    Console.WriteLine("Добавлен объект с высотой: " + newHuman.height);
                    break;
                }
            case NotifyCollectionChangedAction.Remove:
                {
                    Human oldHuman = e.OldItems[0] as Human;
                    Console.WriteLine("Удален объект c высотой: " + oldHuman.height);
                    break;
                }
        }
    }
}

public abstract class IntelligentCreature
{
    public int height { get; set; }
    public string color_skin { get; set; }
    public IntelligentCreature(int Height, string Color_skin)
    {
        height = Height;
        color_skin = Color_skin;
    }
    public virtual void Display()
    {
        Console.WriteLine(height + color_skin);
    }
}
public class Human : IntelligentCreature
{
    public Human(int Height, string Color_skin) : base(Height, Color_skin)
    {
    }
}
public class Transformer : IntelligentCreature
{
    public int hp { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public int tank = 0;
    public Transformer(int Height, string Color_skin, int Tank) : base(Height, Color_skin)
    {
        tank = Tank;
    }
}
class Student
{
    private string name;

    public string Name { get => name; set => name = value; }

    public Student(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return this.name;
    }
}

