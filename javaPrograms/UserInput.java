package Programs;
import java.util.Scanner;


public class UserInput {

	public static void main(String[] args) {
		Scanner scans = new Scanner(System.in);
		System.out.println("Enter the Value");
		int User_Input = scans.nextInt();
		
		System.out.println("The Entered value is");
		System.out.println(User_Input);
		
		Scanner scan1 = new Scanner(System.in);
		System.out.println("Enter the double Value");
		double User_Input_double= scan1.nextDouble();
		
		System.out.println("The Entered value is");
		System.out.println(User_Input_double);
		
		Scanner scan2 = new Scanner(System.in);
		System.out.println("Enter the string");
		String User_Input_string = scan2.nextLine();
		
		System.out.println("The Entered string is");
		System.out.println(User_Input_string);
	}
}
