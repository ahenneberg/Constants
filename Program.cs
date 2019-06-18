/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;


namespace Constants
{
    class Program
    {
        /* A constant is a static field whose value can never change.
         A constant is evaluated statically at compile time and the 
         compiler literally substitutes its value whenever used. A
         constant can ve any of the built-in numeric types:
         bool, char, string, or an enum type.
          
           A constant is declared with the const keyword and must be 
         initialized with a value. For example:  */

        public const string Message = "Hello World";

        /* A constant is much more restrictive than a static readonly
         field - both in the types you can use and in field intialization
         semantic. A constant also differs form a static readonly field in
         that the evaluation of the constant occurs at compile time. 
         For example: */
         public static double Circumference (double radius)
        {
            return 2 * Math.PI * radius;
            /* Is compiled to: 
            return 6.2831853071795862 * radius;
            
            It makes sense for PI to be a constant, since it can never change.
            In contrast, a static readonly field can have a different value 
            per application. */
        }
           

        static void Main(string[] args)
        {
            // Constants can also be declared local to a method. For example:

            const double twoPI = 2 * Math.PI;
        }
        /* Nonlocal constants allow the following modifiers: 
         
         Access modifiers:      public, internal, private, protected
         Inheritance modifier:  new                                 */
    }
}
