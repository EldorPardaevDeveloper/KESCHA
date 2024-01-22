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




if (age > keschasAge)
      {
      Console.WriteLine("You are older!");
      }
      else if(age == keschasAge)
      {
      Console.WriteLine("You are equal");
      }
      else
      {
      Console.WriteLine("You are younger!");
      }



      System.Console.WriteLine("Let me tell you about my friends.");

         string[] friendsName = new string[6];
         friendsName[0] = "Kasee";
         friendsName[1] = "Vasya";
         friendsName[2] = name;
         int[] friendsAge = { 1, 3,age,};


         for(int iteration = 0; iteration < friendsName.Length; iteration++)
         {
                Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} year old!");
         } 


