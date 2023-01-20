public class ClassExample
{
    
}
public class NewClassExample
{

}
public class ClassWithVariables
{
    public int number = 2;
    public string userName = "Bob";
    public double numDecim = 2.12345;
}

public class ClassWithFunctions
{
    public ClassWithVariables stats;

    public void RunFunction()
    {
        stats = new ClassWithVariables();
        Console.WriteLine("Running Function");
        Console.WriteLine("numDecim = " + stats.numDecim);
        Console.WriteLine("number = " + stats.number);
        Console.WriteLine("userName = " + stats.userName);
        
    }
}   