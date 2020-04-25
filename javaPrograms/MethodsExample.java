package Programs;

public class MethodsExample {

	public static int Add(int a,int b)
	{
		return a+b;
	}
	public static void Display() {
		System.out.println("The addition of both the numbers are:");
	}
	public static void main(String[] args) {
	 	int res=Add(20,30);
	 	
	 	Display();
	 	System.out.println(res);
	 	
	 	
	}
}
