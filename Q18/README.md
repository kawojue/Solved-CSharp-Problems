# Question

The Fibonacci Numbers is a sequence of numbers in the following order: 1, 1, 2, 3, 5, 8, 13, 21, 34... The next number is found by adding up the two numbers before it. The formula for calculating these numbers is:

F(n) = F(n-1) + F(n-2)
Where:
F(n) is the term number.
F(n-1) is the previous term (n-1).
F(n-2) is the term before that (n-2).

The first two numbers in the Fibonacci Sequence are 1 and 1, each subsequent
number is the sum of the previous two numbers.
Develop your algorithm that can generate Fibonacci. Write a C# program to implement your Algorithm. Once you do that, follow the next steps.

A user-defined type can overload a predefined C# operator such as +, -, * , /. That is, a type can provide the custom implementation of an operation in case one or both of the operands are of that type. The Overloadable operators section shows which C# operators can be overloaded.
See here: <https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading>

Rewrite the above solution by overloading operators + and ++? For a given nth order Fibonacci Number “Fib”:
Fib++ gives (n+1)th order of the Fibonacci Number
Fib+m gives (n+m)th order of the Fibonacci Number
