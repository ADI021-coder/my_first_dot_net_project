{

    Console.WriteLine("Hello World");
    Console.WriteLine("Age Progression Calculator");

    Console.Write("enter your name: ");
    string userName = Console.ReadLine();

    Console.WriteLine("enter your age: ");
    string userAge = Console.ReadLine();
    int futreAge = Convert.ToInt32(userAge) + 10;
    int futreMonth = Convert.ToInt32(futureAge)*12+60;

    Console.WriteLine("Hi " + userName + ", you will be " + Age + "yrs old in 10 yrs from now! which means " + age + " months old!");

}