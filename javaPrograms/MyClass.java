package Programs;
//Example of Polymorphism
public class MyClass {

		public static void main(String[]args) {
			Bank abc = new Bank_ABC();
			Bank def = new Bank_DEF();
			Bank ghi = new Bank_GHI();
			
			System.out.println(abc.InterestRate());
			System.out.println(def.InterestRate());
			System.out.println(ghi.InterestRate());
		}
		
}
