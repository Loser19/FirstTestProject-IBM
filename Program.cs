// See https://aka.ms/new-console-template for more information
using FirstTestProject_IBM;

Console.WriteLine("welcome to C#");

//VariableDeclarationdemo();
//PersonDetails();
//LoopsDemo();
Studentand5SubjectDemo();

static void Studentand5SubjectDemo()
{
    Studentand5Subjects student = new Studentand5Subjects();

    Console.Write("Enter student name: ");
    string name = Console.ReadLine();

    Console.Write("Enter student age: ");
    int age = int.TryParse(Console.ReadLine(), out int parsedAge) ? parsedAge : 0;

    string[] subjects = new string[5];
    int[] marks = new int[5];

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Enter subject {i + 1} name: ");
        subjects[i] = Console.ReadLine();

        Console.Write($"Enter marks for {subjects[i]}: ");
        marks[i] = int.TryParse(Console.ReadLine(), out int parsedMark) ? parsedMark : 0;
    }

    student.DisplayStudentInfo(name, age, subjects, marks);
}
static void LoopsDemo()
{
    Loops loops = new Loops();
    loops.ForLoopExample();
    loops.WhileLoopExample();
    loops.DoWhileLoopExample();
}

//int result = Calculator();
//Console.WriteLine($"The result is: {result}");
static int Calculator()
{
    Calculator calculator = new Calculator();
    Console.WriteLine("Please enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter operation: ");
    string operation = Console.ReadLine();
    int result = 0;
    switch (operation.ToLower())
    {
        case "add":
            result = calculator.Add(firstNumber, secondNumber);
            break;
        case "subtract":
            result = calculator.Subtract(firstNumber, secondNumber);
            break;
        case "multiply":
            result = calculator.Multiply(firstNumber, secondNumber);
            break;
        case "divide":
            try
            {
                result = calculator.Divide(firstNumber, secondNumber);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0; // Exit if division by zero
            }
            break;
        default:
            Console.WriteLine("Invalid operation");
            return 0; // Exit if invalid operation
    }
    //Console.WriteLine($"The result of {operation}ing {firstNumber} and {secondNumber} is: {result}");
    return result;
}

static void VariableDeclarationdemo()
{
    int number = 10;
    String greeting = "Helloi, c#";

    Console.WriteLine($"Number: {number} and {greeting}");

    // previous type of variable incorporation
    Console.WriteLine("Number: {0} and {1}", number, greeting);
}

static void PersonDetails()
{
    Console.WriteLine("Please enter your name: ");
    String name = Console.ReadLine();

    Console.WriteLine("Please enter your city: ");
    String city = Console.ReadLine();

    Console.WriteLine("please enter your age: ");
    //int age = Console.ReadLine != null ? int.Parse(Console.ReadLine()) : 0;
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello, {name} from {city}, you are {age} years old! ");
}