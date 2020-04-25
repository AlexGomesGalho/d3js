package Programs;

import java.util.LinkedList;

//class Polygon
//class Rectangle
//class Traingle
public class Inheritance {

	public static void main(String[]args) {
		
		Traingle Trai = new Traingle();
		Rectangle Rect = new Rectangle();
		
		Trai.set_value(10, 20);
		Rect.set_value(25, 35);
		
		System.out.println("Area of Rectangle is :"+Rect.area());
		System.out.println("Area of Traingle is :"+Trai.area());
		
		LinkedList<String> name = new LinkedList<String>();
		name.add("Aditya");
		name.add("Sharma");
		name.addFirst("Mr");
		name.addLast("Hello");
		System.out.println(name.size());
		
		for (String x :name)
			System.out.println(x);
	}
}
