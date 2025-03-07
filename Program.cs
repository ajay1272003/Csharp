using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            int a = 30;
            double b = 9.99;
            bool isActive = true;
            char grade = 'A';
            string name = "Alice";

            // Perform arithmetic operations and display the results
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // Checking if a is greater than b and not equal to b
            if (a > b && a != b)
            {
                Console.WriteLine(name + " got " + grade);
            }

            // Checking if a is equal to or greater than b
            if (a == b || a >= b)
            {
                Console.WriteLine(a + " is greater than or equal to " + b);
            }

            // Checking if b is less than or equal to a
            if (b < a && b <= a)
            {
                Console.WriteLine(b + " is smaller than " + a);
            }
            // Printing opposite of isActive value
            Console.WriteLine(!isActive);
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int userno = 0;
            Random random = new Random();
            int num = random.Next(1, 100);
            while (userno != num)
            {
                Console.WriteLine("Guess a number");
                userno = int.Parse(Console.ReadLine());
                if (userno > num)
                {
                    Console.WriteLine("Too high");
                }
                else if (userno < num)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct guess");
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

public class LambdaLinqExample
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Even numbers:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

public class LinqProductExample
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Iphone", Category = "Apple", Price = 799 },
            new Product { Name = "Macbook", Category = "Apple", Price = 1199 },
            new Product { Name = "Qled TV", Category = "Samsung", Price = 2999 },
            new Product { Name = "Pixel", Category = "Google", Price = 999 },
            new Product { Name = "Ipad", Category = "Apple", Price = 699 }
        };

        string targetCategory = "Apple";
        var electronicsProducts = products.Where(p => p.Category == targetCategory);

        Console.WriteLine($"Products in category '{targetCategory}':");
        foreach (var product in electronicsProducts)
        {
            Console.WriteLine($"- {product.Name}, Price: ${product.Price}");
        }

        double averagePrice = electronicsProducts.Average(p => p.Price);
        Console.WriteLine($"\nAverage price of products in '{targetCategory}': ${averagePrice}");
    }
}



using System;
using System.Collections.Generic;

public class DelegateExample
{
    public delegate int MathOperation(int a, int b);

    public static int Add(int a, int b) { return a + b; }
    public static int Subtract(int a, int b) { return a - b; }
    public static int Multiply(int a, int b) { return a * b; }
    public static int Divide(int a, int b) { return a / b; }

    public static void Main(string[] args)
    {
        MathOperation operation = Add;
        Console.WriteLine($"Result of addition: {operation(10, 5)}");

        operation = Subtract;
        Console.WriteLine($"Result of subtraction: {operation(10, 5)}");

        operation = Multiply;
        Console.WriteLine($"Result of multiplication: {operation(10, 5)}");

        operation = Divide;
        Console.WriteLine($"Result of division: {operation(10, 5)}");
    }
}


using System;
using System.Collections.Generic;

namespace EcommerceApp
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void DisplayProduct()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price}, Quantity: {Quantity}");
        }
    }

    class ShoppingCart
    {
        private List<Product> cartItems = new List<Product>();

        public void AddProduct(Product product)
        {
            cartItems.Add(product);
            Console.WriteLine($"{product.Name} added to the cart.");
        }

        public void RemoveProduct(int id)
        {
            Product product = cartItems.Find(p => p.Id == id);
            if (product != null)
            {
                cartItems.Remove(product);
                Console.WriteLine($"{product.Name} removed from the cart.");
            }
            else
            {
                Console.WriteLine("Product not found in the cart.");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Your Shopping Cart:");
            if (cartItems.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
            }
            else
            {
                foreach (var product in cartItems)
                {
                    product.DisplayProduct();
                }
            }
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in cartItems)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Macbook", Price = 65000, Quantity = 1 },
                new Product { Id = 2, Name = "iPhone", Price = 60000, Quantity = 1 },
                new Product { Id = 3, Name = "iPad", Price = 40000, Quantity = 1 }
            };

            ShoppingCart cart = new ShoppingCart();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Add to Cart");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Remove from Cart");
                Console.WriteLine("5. Checkout");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nAvailable Products:");
                            foreach (var product in products)
                            {
                                product.DisplayProduct();
                            }
                            break;

                        case 2:
                            Console.Write("Enter the product ID to add to the cart: ");
                            int addId = int.Parse(Console.ReadLine());
                            Product productToAdd = products.Find(p => p.Id == addId);
                            if (productToAdd != null)
                            {
                                cart.AddProduct(productToAdd);
                            }
                            else
                            {
                                Console.WriteLine("Product not found.");
                            }
                            break;

                        case 3:
                            cart.DisplayCart();
                            break;

                        case 4:
                            Console.Write("Enter the product ID to remove from the cart: ");
                            int removeId = int.Parse(Console.ReadLine());
                            cart.RemoveProduct(removeId);
                            break;

                        case 5:
                            Console.WriteLine($"Total Amount: {cart.CalculateTotal()}");
                            Console.WriteLine("Checkout complete. Thank you for shopping!");
                            cart = new ShoppingCart();
                            break;

                        case 6:
                            running = false;
                            Console.WriteLine("Exiting... Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}


using System;
using System.Timers;

public class Clock
{
    public event EventHandler OnTick;
    private Timer timer;

    public Clock()
    {
        timer = new Timer(1000);
        timer.Elapsed += (s, e) => OnTick?.Invoke(this, EventArgs.Empty);
        timer.AutoReset = true;
        timer.Enabled = true;
    }
}

public class Display
{
    public void Subscribe(Clock clock)
    {
        clock.OnTick += (s, e) => Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Clock clock = new Clock();
        Display display = new Display();
        display.Subscribe(clock);
        Console.WriteLine("Clock is running... Press enter key to stop");
        Console.ReadLine();
    }
}




using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

public class ComplexLinqExample
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Sony", Category = "Camera", Price = 50000 },
            new Product { Name = "Canon", Category = "Camera", Price = 45000 },
            new Product { Name = "Apple", Category = "Phone", Price = 60000 },
            new Product { Name = "Samsung", Category = "Phone", Price = 65000 },
            new Product { Name = "Nikon", Category = "Camera", Price = 40000 },
            new Product { Name = "Google", Category = "Phone", Price = 70000 }
        };

        var categoryCounts = products
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count);

        foreach (var categoryCount in categoryCounts)
        {
            Console.WriteLine($"Category: {categoryCount.Category}, Count: {categoryCount.Count}");
        }
    }
}



using System;
using System.Collections.Generic;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public override double GetArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle { Width = 10, Height = 20 },
            new Triangle { SideA = 5, SideB = 10, SideC = 15 },
            new Circle { Radius = 10 }
        };

        double totalArea = 0;
        double totalPerimeter = 0;

        foreach (var shape in shapes)
        {
            totalArea += shape.GetArea();
            totalPerimeter += shape.GetPerimeter();
        }

        Console.WriteLine($"Total Area: {totalArea}");
        Console.WriteLine($"Total Perimeter: {totalPerimeter}");
    }
}



using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> elements = new List<T>();

    // Push method to add an item to the stack
    public void Push(T item)
    {
        elements.Add(item);
    }

    // Pop method to remove and return the top item from the stack
    public T Pop()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        T topItem = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return topItem;
    }

    // Peek method to return the top item without removing it
    public T Peek()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        return elements[elements.Count - 1];
    }
}

// Testing the generic Stack<T> class
public class Program
{
    public static void Main()
    {
        // Testing with integers
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine($"Top of int stack: {intStack.Peek()}"); // Output: 30
        Console.WriteLine($"Popped: {intStack.Pop()}"); // Output: 30
        Console.WriteLine($"Popped: {intStack.Pop()}"); // Output: 20

        // Testing with strings
        Stack<string> stringStack = new Stack<string>();
        stringStack.Push("Tony");
        stringStack.Push("Peter");
        stringStack.Push("Justin");
        Console.WriteLine($"Top of string stack: {stringStack.Peek()}"); // Output: Charlie
        Console.WriteLine($"Popped: {stringStack.Pop()}"); // Output: Charlie
        Console.WriteLine($"Popped: {stringStack.Pop()}"); // Output: Bob
    }
}



using System;
using System.Reflection;

public class ObjectSerializer
{
    // Method to serialize an object into a string with its property names and values
    public static string SerializeObject(object obj)
    {
        if (obj == null)
            throw new ArgumentNullException(nameof(obj), "Object cannot be null.");

        Type type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties();
        string result = $"Object of type {type.Name}:\n";

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(obj);
            result += $"{property.Name}: {value}\n";
        }

        return result;
    }
}

// Test classes
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Product
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Test with the Person class
        Person person = new Person { Name = "Tony", Age = 56 };
        string personSerialized = ObjectSerializer.SerializeObject(person);
        Console.WriteLine(personSerialized);

        // Test with the Product class
        Product product = new Product { ProductName = "iPhone 15", Price = 50000 };
        string productSerialized = ObjectSerializer.SerializeObject(product);
        Console.WriteLine(productSerialized);
    }
}




using System;
using System.IO;

// Define the ILogger interface
public interface ILogger
{
    void LogInfo(string message);
    void LogWarning(string message);
    void LogError(string message);
}

// Implement ConsoleLogger
public class ConsoleLogger : ILogger
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"INFO: {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"WARNING: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"ERROR: {message}");
    }
}

// Implement FileLogger
public class FileLogger : ILogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }

    public void LogInfo(string message)
    {
        WriteLog($"INFO: {message}");
    }

    public void LogWarning(string message)
    {
        WriteLog($"WARNING: {message}");
    }

    public void LogError(string message)
    {
        WriteLog($"ERROR: {message}");
    }

    private void WriteLog(string message)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}

// Using Dependency Injection
public class Application
{
    private readonly ILogger logger;

    public Application(ILogger logger)
    {
        this.logger = logger;
    }

    public void Run()
    {
        logger.LogInfo("Application started.");
        logger.LogWarning("This is a warning.");
        logger.LogError("An error occurred.");
    }
}

// Test the logging mechanism
public class Program
{
    public static void Main()
    {
        // Using ConsoleLogger
        ILogger consoleLogger = new ConsoleLogger();
        Application app1 = new Application(consoleLogger);
        app1.Run();

        Console.WriteLine();

        // Using FileLogger
        ILogger fileLogger = new FileLogger("logs.txt");
        Application app2 = new Application(fileLogger);
        app2.Run();

        Console.WriteLine("Logs have been written to the file.");
    }
}