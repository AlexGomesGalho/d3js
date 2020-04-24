using System;
class Program
    {
    static void Main()
    {
        Console.WriteLine("Example of taking Input And Output");
        Console.WriteLine("Enter Your First name");
       string UserFname = Console.ReadLine();
       Console.WriteLine("ENter Your Second Name");
       string UserSname = Console.ReadLine();
       Console.WriteLine("Hello {0} {1}", UserFname,UserSname);

        Console.WriteLine("\n");
        Console.WriteLine("Displaying the size of int datatype");
        Console.WriteLine("MinValue {0}\n MaxValue{1} ", int.MinValue, int.MaxValue);

        Console.WriteLine("\n");
        //EscapeSequences
        //string Location = "C:\\Users\\Aditya\\Desktop";
        //string Loc = @"C:\\Users\\Aditya\\Desktop";
        //Console.WriteLine("{0}\n {1} ",Loc,Location);


        //Operators
        Console.WriteLine("Example for Operators");
        Console.WriteLine("ENter Your Num1");
       int num =Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("ENter Your Num2");
       int num2 = Convert.ToInt32(Console.ReadLine());

       int result = num + num2;
       int result1 = num * num2;
       float result2 = num / num2;
       int result3 = num2 - num;
       Console.WriteLine("Add= {0}\n MUL={1}\n DIV={2}\n SUB={3}", result, result1, result2, result3);
        Console.WriteLine("\n");
        Console.WriteLine("Example of Boolen operator");
        if (result1 == result2)
           Console.WriteLine(true);
       else
           Console.WriteLine(false);
        
        Console.WriteLine("\n");

        //ARRAY
        Console.WriteLine("Entering values in array and displaying a particular index value");
        int[] Aditya = new int[20];
       Aditya[0] = 156;
       Aditya[1] = 256;
       Aditya[3] = 565;
       Console.WriteLine(Aditya[3]);
        
        Console.WriteLine("\n");
        
        Console.WriteLine("Example for Switch statement");
    
        //SwitchStatements
    Start:
       Console.WriteLine("These are the varities of coffee.Please choose Yours\n 1-Small , 2- Medium , 3-Large");
       int totalAmount = 0;
       int Userchoice = int.Parse(Console.ReadLine());

       switch(Userchoice)
       {
           case 1:


               totalAmount += 56;
               Console.WriteLine("You have selected Small and your bill amount is {0}", totalAmount);
               break;

           case 2:

               totalAmount += 88;
               Console.WriteLine("You have selected Mediumur bill amount is {0}", totalAmount);
               break;

           case 3:

               totalAmount += 105;
               Console.WriteLine("You have selected Largeyour bill amount is {0}", totalAmount);
               break;
           default:
               Console.WriteLine("Your Choice is invalid.ThankYou");
               break;
        }
       Console.WriteLine("Do You Want to Try Again:YES OR NO");
       String Request =Console.ReadLine();
       switch (Request)
       { 

           case"YES":
           goto Start;
           case "No":
           break;
       }
        
        Console.WriteLine("\n");
        Console.WriteLine("Example for Do-While loop");
        
        string userchoice = "";
        do
        {
            Console.WriteLine("Printing Even Number");
            Console.WriteLine("Enter your Target!!");
            int userTarget = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= userTarget)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            do
              
            {
                Console.WriteLine("Do you want to continue again!!YES OR NO");
                userchoice = Console.ReadLine().ToUpper();
                if (userchoice != "YES" && userchoice != "NO")
                {
                    Console.WriteLine("Invalid input Please Try again!!YES OR NO");

                }

            } while (userchoice != "YES" && userchoice != "NO");

        } while (userchoice == "YES");
        
        Console.WriteLine("\n");
        Console.WriteLine("Examples for foreach loop");

        int[] number = new int[4];
        number[0] = 10;
        number[1] = 20;
        number[2] = 35;
        number[3] = 45;
            
        foreach (int k in number)
            Console.WriteLine(k);
    }
}
