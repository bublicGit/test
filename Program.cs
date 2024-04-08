namespace LPR_RCIS_2_7_task4;

public class Program
{
    public static void Main()
    {
        Counter counter = new Counter();
        List <Person>  persons = new List<Person>();

        Console.Write("Введите начальное значение счетчика: ");
        counter.i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(counter.i);
        

        while (counter.i != 10 & counter.i < 10)
        {
            counter.Increase();
        }
        
        Console.WriteLine(counter.i);

        while (counter.i != 5)
        {
            counter.Reduce();
        }
        
        Console.WriteLine(counter.i);
    }
}