int number1;
int number2;
int number3;

int[] numbers = new int[3];

Console.WriteLine("Wprowadź pierwszą liczbę całkowitą:");
var enteredNumber1 = Console.ReadLine();
Int32.TryParse(enteredNumber1, out number1);
numbers[0] = number1;

Console.WriteLine("Wprowadź drugą liczbę całkowitą:");
var enteredNumber2 = Console.ReadLine();
Int32.TryParse(enteredNumber2, out number2);
numbers[1] = number2;

Console.WriteLine("Wprowadź trzecią liczbę całkowitą:");
var enteredNumber3 = Console.ReadLine();
Int32.TryParse(enteredNumber3, out number3);
numbers[2]= number3;


Console.WriteLine($"{numbers.Max()} jest największa z podanych");
