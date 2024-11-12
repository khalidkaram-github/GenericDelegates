namespace GenericDelegates
{
    class Program
    {
        static int Double(int x) { return x * 2; }
        static void Main(string[] args)
        {
            #region Func Examples

            // Example 1: Simple Math Operation
            Func<int, int> doubleNumber = x => x * 2;

            Console.WriteLine("Double of 4 is: " + doubleNumber(4));  // Output: 8

            // Example 2: Concatenate Strings
            Func<string, string, string> concatenate = (str1, str2) => str1 + " " + str2;
            Console.WriteLine(concatenate("Hello", "World"));  // Output: Hello World

            // Example 3: Calculate Area of a Rectangle
            Func<int, int, int> areaOfRectangle = (width, height) => width * height;
            Console.WriteLine("Area of rectangle (5,10): " + areaOfRectangle(5, 10));  // Output: 50

            #endregion

            #region Action Examples

            // Example 1: Print a Message
            Action<string> printMessage = message => Console.WriteLine("Message: " + message);
            printMessage("Hello, Action!");  // Output: Message: Hello, Action!

            // Example 2: Add an Element to a List
            List<int> numbers = new List<int> { 1, 2, 3 };
            Action<int> addNumber = num => numbers.Add(num);
            addNumber(4);
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));  // Output: 1, 2, 3, 4

            // Example 3: Log Information to Console
            Action<string> logInfo = info => Console.WriteLine($"[INFO]: {info}");
            logInfo("This is a log message.");  // Output: [INFO]: This is a log message.

            #endregion

            #region Predicate Examples

            // Example 1: Check If Number is Even
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine("Is 4 even? " + isEven(4));  // Output: True

            // Example 2: Check If String is Null or Empty
            Predicate<string> isNullOrEmpty = str => string.IsNullOrEmpty(str);
            Console.WriteLine("Is '' null or empty? " + isNullOrEmpty(""));  // Output: True

            // Example 3: Check If List Contains a Specific Value
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            Predicate<string> containsBob = name => name == "Bob";
            bool hasBob = names.Exists(containsBob);
            Console.WriteLine("Does list contain 'Bob'? " + hasBob);  // Output: True

            #endregion
        }
    }
}
