package Programs;

import java.util.Scanner;

public class Operators {
 
	public static void main(String[] args) {
		System.out.println("Enter the First values");
		Scanner scan1 = new Scanner(System.in);
		int x = scan1.nextInt();
		System.out.println("Enter the Second values");
		int y = scan1.nextInt();
		
		double Add = x+y;
		System.out.println("The Addition of th Interger is"+Add);
		
		int Sub = x-y;
		System.out.println("The Subtration of th Interger is"+Sub);
		
		int Mul = x*y;
		System.out.println("The Multiplication of th Interger is"+Mul);
		
		int Div = x/y;
		System.out.println("The Division of th Interger is"+Div);
	}
}
