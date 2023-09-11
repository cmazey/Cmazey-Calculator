Console.WriteLine ("--- CMAZEY CALCULATOR ---");
Console.WriteLine("ALPHA v1.07");

Console.WriteLine("\nType /help to show all the available commands!");

bool cmazeyCalculator = true;

while (cmazeyCalculator)
{
Console.Write("-> ");
string input = Console.ReadLine();

// ADDITION
if (input == "Addition")
{
  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: ADDITION [+]");
  Console.Write("\n? + ? = -> ");
  int add1 = Convert.ToInt32(Console.ReadLine());
  Console.Write($"{add1} + ? = ? -> ");
  int add2 = Convert.ToInt32(Console.ReadLine());

  int addTotal = add1 + add2; // Adds the numbers

  Console.WriteLine($"\n{add1} + {add2} = {addTotal}");
  Console.ReadLine();
}
  
// SUBTRACTION
  else if (input == "Subtraction") 
{
  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: SUBTRACTION [-]");

  Console.Write("\n ? - ? = ? -> ");
  int sub1 = Convert.ToInt32(Console.ReadLine());
  Console.Write($"{sub1} - ? = ? -> ");
  int sub2 = Convert.ToInt32(Console.ReadLine());

  int subTotal = sub1 - sub2; // Subtracts the numbers
  
  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: SUBTRACTION [-]");
  Console.WriteLine($"\n{sub1} - {sub2} = {subTotal}");
  Console.ReadLine();
}
  
// HELP COMMAND
else if (input == "/help")
{
  Console.WriteLine("\n- Addition");
  Console.WriteLine("- Subtraction");
  Console.WriteLine("- Multiplication");
  Console.WriteLine("- Division");
  Console.WriteLine("- Change\n");
}
  
// MULTIPLICATION
else if (input == "Multiplication")
{
  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: MULTIPLICATION [x]");

  Console.Write("? x ? = ? -> ");
  int mult1 = Convert.ToInt32(Console.ReadLine());
  Console.Write($"{mult1} x ? = ? -> ");
  int mult2 = Convert.ToInt32(Console.ReadLine());

  int multTotal = mult1 * mult2; // Multiply the number

  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: MULTIPLICATION [x]");
  
  Console.WriteLine($"\n{mult1} x {mult2} = {multTotal}");
  Console.ReadLine();
}
  
// DIVISION / DIVIDE
else if (input == "Division")
{
  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: DIVISION [/]");

  Console.Write("? / ? = ? -> ");
  double div1 = Convert.ToDouble(Console.ReadLine());
  Console.Write($"{div1} / ? = ? -> ");
  double div2 = Convert.ToDouble(Console.ReadLine());

  double divTotal = (div1 / div2); // Divides the numbers

  Console.Clear();
  Console.WriteLine("CMAZEY CALCULATOR: DIVISION [/]");

  Console.WriteLine($"\n{div1} / {div2} = {divTotal}");
  Console.ReadLine();
}
    
//CHANGECALCULATOR // CHANGE
else if (input == "Change")
{
    Console.Clear();
    Console.WriteLine("CMAZEY CALCULATOR: CHANGE CALCULATOR [₵]");

    Console.Write("\nEnter change to give back (1c - 99c): ");
    int change = Convert.ToInt32(Console.ReadLine());
    
    int Quarters = (change / 25); // Divides the change amount by 25.
    int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, and subtract it by the change amount, then divide it by 10.
    int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and Dime, then add them all, and subtract it by the change amount, then divide it by 5.
    int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the Quarter, Dime, and Nickel, and add them all, then subtract it by the change amount, and divide it by 1;
      
    Console.Clear();
    Console.WriteLine("CMAZEY CALCULATOR: CHANGE CALCULATOR [₵]");

    Console.WriteLine($"Change Amount: {change}₵");
    
    Console.WriteLine($"\nQuarters: {Quarters}");
    Console.WriteLine($"Dimes: {Dimes}");
    Console.WriteLine($"Nickels: {Nickels}");
    Console.WriteLine($"Pennies: {Pennies}");
    
    Console.ReadLine();
}

//Clear
else if (input == "Clear")
{
Console.Clear();
Console.WriteLine("\nType /help to show all the available commands!\n");
}
      
//INVALID RESPONSE
else 
{
  Console.WriteLine("Invalid Command, please try again.");
  Console.WriteLine("P.S. The first letter of the command is always capital");
}
}