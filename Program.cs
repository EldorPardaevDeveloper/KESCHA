System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");   
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"successfuly converted! {age}");

int keschasAge = 3;
int ageDifference = age - keschasAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");

// > >= < <= == !=

System.Console.WriteLine($"You are older than KESCHA: {age > keschasAge}");
System.Console.WriteLine($"You are younger than KESCHA: {age < keschasAge}");
System.Console.WriteLine($"You are older than or equal to KESCHA: {age >= keschasAge}");
System.Console.WriteLine($"You are less than or equal to KESCHA: {age <= keschasAge}");
System.Console.WriteLine($"Are you equal to KESCHA: {age == keschasAge}");
System.Console.WriteLine($"Are you no match for KESCHA: {age != keschasAge}");