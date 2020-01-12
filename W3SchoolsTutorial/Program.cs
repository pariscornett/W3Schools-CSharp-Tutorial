using System; //uses namespace "System"---without "using" it at the beginning, you'd have to call it in each instance (ex. System.Console.WriteLine())

namespace W3SchoolsTutorial //namespaces keep code organized and hold other namespaces and classes
{  //code blocks denoted with curly braces
    class Program //classes bring functionality to program. Every line of code that runs in C# has to be inside a class. Classes contain data and methods. 
    {
        static void Main(string[] args)  //"static" and "void" are properties of OOP. static means a method can be accessed without creating an instance of the class. Void means the method will not return anything. Main is the main method, and everything within its curly braces will be run. 
        {
            Console.WriteLine("Hello World!"); //Console with a capital "C" is a class of the namespace System. WriteLine is a method within it (like console.log)
            Console.WriteLine("This is the WriteLine method and will print on a new line"); //see below

            Console.Write("Hello Again, World!");
            Console.Write("This is the Write method and will print on the same line");

            string hello = "Hello World, I am a variable";
            Console.WriteLine(hello);

            hello = "I changed my mind about this variable";
            Console.WriteLine(hello);

            const int cantChangeThis = 100;
            Console.WriteLine(cantChangeThis);

            //THE CODE BELOW WILL THROW AN ERROR BECAUSE WE MADE THE VARIABLE WE ARE TRYING TO ASSIGN HERE A CONSTANT
            //cantChangeThis = 200;
            //Console.WriteLine(cantChangeThis);
        }
    }
}

//----NOTES ON CODE ABOVE
//every statement in C# ends with a semicolon ;
//this language is also case sensitive
//"Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization)." --This is the same in React
//"When saving a file, save it using a proper name and add '.cs' at the end of the filename.


//----WRITELINE OR WRITE?
//the most common method for outputting code to the console is WriteLine();, but Write(); also works.
//WriteLine(); prints on a new line every time
//Write(); prints on the same line
//remember to add spaces for better readability.
