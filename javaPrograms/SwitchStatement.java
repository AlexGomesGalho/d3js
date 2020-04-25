package Programs;

import java.util.Scanner;

public class SwitchStatement {

	public static void main(String[]args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Please Enter the Grade");
		String score = scan.nextLine();
		
		switch (score)
		{
			case "A":
				System.out.println("Very Good");
				break;
			case "B":
				System.out.println("Average");
				break;
			case "C":
				System.out.println("Pooor");
				break;
			case "D":
				System.out.println("Fail");
				break;
			default:
				System.out.println("Please Enter correct value");
		}
	}
 
}