package Area;
import java.util.Scanner;

public class TrapezioArea {

	public static void main(String[] args) {
			float  h,b,B,area;
		
		Scanner scan = new Scanner(System.in);
		System.out.println("Informe a Altura");
		h = scan.nextFloat();
		System.out.println("Informe a Base Menor");
		b = scan.nextFloat();
		System.out.println("Informe a Base Maior");
		B = scan.nextFloat();
		
		
		area = (h * (b+B))/2;
		int area2 = (int) area; 
		System.out.println("Valor a Area: " + area);
		System.out.println("Valor a Area: " + area2);
		
		

	}

}
