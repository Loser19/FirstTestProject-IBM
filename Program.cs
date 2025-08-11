// See https://aka.ms/new-console-template for more informationusing FirstTestProject_IBM;
using FirstTestProject_IBM;

Console.WriteLine("                                 ATTENTION!! Everything you see here is done by CO-PILOT");
Console.WriteLine();

//Console.WriteLine(int.MinValue + " " + int.MaxValue);
//Console.WriteLine(long.MinValue + " " + int.MaxValue);
//Console.WriteLine(float.MinValue + " " + int.MaxValue);
//Console.WriteLine(double.MinValue + " " + int.MaxValue);
//Console.WriteLine(decimal.MinValue + " " + int.MaxValue);
//Console.WriteLine(char.MinValue + " " + char.MaxValue);
//Console.WriteLine(bool.FalseString + " " + bool.TrueString);


//VariableDeclarationdemo();
//PersonDetails();
//LoopsDemo();
//Studentand5SubjectDemo();
//TwoDimensionArraydemo();
//JaggedArraysdemo();
//EmployeeDemoProgram();
//ProductDemo();
//PersonDetailsDemo();

InheritanceDemo1();
static void InheritanceDemo1()
{
    InheritanceDemo1 employeee = new InheritanceDemo1();
    Console.WriteLine("Please enter your Employee ID: ");
    employeee.EmployeeID = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Employee Name: ");
    employeee.Name = Console.ReadLine();
    Console.WriteLine("Please enter your Employee Age: ");
    employeee.Age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Employee Address: ");
    employeee.Address = Console.ReadLine();
    Console.WriteLine("Please enter your Employee Phone Number: ");
    employeee.PhoneNumber = Console.ReadLine();
    Console.WriteLine("Please enter your Employee Email: ");
    employeee.Email = Console.ReadLine();
    Console.WriteLine("Please enter your Employee Occupation: ");
    employeee.Occupation = Console.ReadLine();
    Console.WriteLine("Please enter your Employee Department: ");
    employeee.Department = Console.ReadLine();
    employeee.DisplayPersonDetails();
    employeee.DisplayEmployeeDetails();
}


static void PersonDetailsDemo()
{
    // Create and set details directly (no user input)
    PersonDetails person = new PersonDetails();
    person.UpdatePersonDetails(
        name: "Alice Johnson",
        age: 30,
        address: "123 Main Street, Springfield",
        phoneNumber: "555-1234",
        email: "alice.johnson@example.com",
        occupation: "Software Engineer"
    );

    Console.WriteLine("--- Person Details ---");
    person.DisplayPersonDetails();
}


static void EmployeeDemoProgram()
{ 
    EmployeeDemo employeeDemo = new EmployeeDemo();
    employeeDemo.RunEmployeeDemo();
}



static void JaggedArraysdemo()
{
    int[][] jaggedArray = new int[3][];
    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5, 6, 7 };
    jaggedArray[2] = new int[] { 8, 9 };
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j] + " ");
        }
        Console.WriteLine();
    }
}


static void TwoDimensionArraydemo()
{
    int[,] twoDimensionalArray = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            Console.Write(twoDimensionalArray[i, j] + " ");
        }
        Console.WriteLine();
    }

}

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
    static void ProductDemo()
    {
        Console.Write("How many Products you want to Manage? ");
        int productCount;
        while (!int.TryParse(Console.ReadLine(), out productCount) || productCount <= 0)
        {
            Console.WriteLine("Please Enter a Valid Positive Integer.");
            Console.Write("How many Products do you want to Manage? ");
        }
        List<Product> products = new List<Product>();
        // Input product details
        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine($"\nEnter Details for Product #{i + 1}:");
            Console.Write("Product Name: ");
            string name = Console.ReadLine();
            double price;
            while (true)
            {
                Console.Write("Product Price: ");
                if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                    break;
                Console.WriteLine("Invalid price. Please enter a non-negative number.");
            }
            int quantity;
            while (true)
            {
                Console.Write("Product Quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                    break;
                Console.WriteLine("Invalid Quantity. Please Enter a Non-Negative Integer.");
            }
            products.Add(new Product(name, price, quantity));
        }
        while (true)
        {
            Console.WriteLine("\n--- Product List ---");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].ProductName}");
            }
            Console.WriteLine($"{products.Count + 1}. Exit");
            Console.Write("Select a Product to Perform Operations: ");
            if (!int.TryParse(Console.ReadLine(), out int selected) || selected < 1 || selected > products.Count + 1)
            {
                Console.WriteLine("Invalid Selection. Try again.");
                continue;
            }
            if (selected == products.Count + 1)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            Product product = products[selected - 1];
            while (true)
            {
                Console.WriteLine($"\n--- Operations for {product.ProductName} ---");
                Console.WriteLine("1. Display Product Details");
                Console.WriteLine("2. Calculate Total Price");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Check Stock Availability");
                Console.WriteLine("5. Restock Product");
                Console.WriteLine("6. Sell Product");
                Console.WriteLine("7. Update Product Price");
                Console.WriteLine("8. Back to Product List");
                Console.Write("Enter your Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        product.DisplayProductDetails();
                        break;
                    case "2":
                        Console.WriteLine($"Total Price: {product.CalculateTotalPrice()}");
                        break;
                    case "3":
                        Console.Write("Enter Discount Percentage: ");
                        if (double.TryParse(Console.ReadLine(), out double discount))
                        {
                            Console.WriteLine($"Price after {discount}% Discount: {product.ApplyDiscount(discount)}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                        }
                        break;
                    case "4":
                        Console.WriteLine($"Is the product in stock? {(product.IsInStock() ? "Yes" : "No")}");
                        break;
                    case "5":
                        Console.Write("Enter Quantity to Re-stock: ");
                        if (int.TryParse(Console.ReadLine(), out int restockQty))
                        {
                            product.Restock(restockQty);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                        }
                        break;
                    case "6":
                        Console.Write("Enter Quantity to Sell: ");
                        if (int.TryParse(Console.ReadLine(), out int sellQty))
                        {
                            product.Sell(sellQty);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "7":
                        Console.Write("Enter New Price: ");
                        if (double.TryParse(Console.ReadLine(), out double newPrice))
                        {
                            product.UpdatePrice(newPrice);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "8":
                        // Go back to product list
                        goto EndProductMenu;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        EndProductMenu:;
        }
    }