namespace ClassDemo;

class Staff
{
    //This is known as access modifier
    private string nameOfStaff;
    private const int hourlyRate = 30;
    private int hWorked;


    public int HoursWorked
    {
        get => hWorked;
        set
        {
            if (value > 0)
                hWorked = value;
            else
            {
                hWorked = 0;
            }
        }
    }

    public void PrintMessage()
    {
        Console.WriteLine("Calculating Pay");
    }

    public int CalculatePay()
    {
        PrintMessage();
        int staffPay;
        staffPay = hWorked * hourlyRate;
        
        if(hWorked > 0)
            return staffPay;
        else
        {
            return 0;
        }
    }

    public int CalculatePay(int bonus, int allowance)
    {
        PrintMessage();
        
        if(hWorked > 0)
            return hWorked * hourlyRate + bonus + allowance;
        else
        {
            return 0;
        }
            
    }

    public override string ToString()
    {
        return $"Name of Staff = {nameOfStaff}, hourlyRate = {hourlyRate}, hWorked = {hWorked}";
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}