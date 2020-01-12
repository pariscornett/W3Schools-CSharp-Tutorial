using System;

namespace W3SchoolsTutorial
{
    public class Variables //this class doesn't do anything
    {
        public Variables()  //nothing is returned or output here
        {
            
        }
    }
}


//--NOTES ON VARIABLES
// In C#, variables are defined by their data type rather than general variable keywords like "var" "let" and "const" in JavaScript
// "int" : stores whole number integers without decimals (ex: 150, -637)
// "double" : stores floating point numbers, aka numbers with decimals. (ex: 34.08, -5.23)
// "char" : stores single characters, and the characters (i.e. the data values) are surrounded by single quotes (ex: 'f' or 'Y')
// "string" : stores strings. this one is self explanatory for anyone who is familiar with a programming language. surrounded by double quotes ( "string" or "My name is Paris")
// "bool" : stores booleans, which have two states: true or false.

//--VARIABLE SYNTAX IN C#
// Syntax is the same as with JavaScript and follows this structure:
// type variableName = value;
// ex: int exampleNumber = 5;
// see Program.cs for an example of the variable hello being printed to the console.

//--VARIABLE RULES
// Just like in JavaScript, existing C# variables can be reassigned and overwritten by calling the variable name, and reassigning its value.
// For example: exampleNumber = 10; ---this would change the example from the previous section's value from 5 to 10.
// See Program.cs for an example of the variable hello being reassigned.
// TO PREVENT VARIABLES BEING OVERWRITTEN, you can add in the "const" keyword.
// Constants in C# are just like in ES6. This makes variables immutable.
// Syntax for an immutable variable in C# looks like this: const int cantChangeThis = 100;
// We can concatenate variables with strings or other variables when printing to the console using the "+" symbol, just like in JavaScript
// Variable names are called "identifiers"
// You can declare multiple variables of the same data type using commas like this:
//     int x = 5, y = 10, z = 90;