import java.util.Scanner;

public class EstruturaFor{

		public static void main(String[] args){

			Scanner entrada = new Scanner(System.in);

			System.out.println("Digite um Numero: ");
			int NumeroInicial = entrada.nextInt();

			for (int i = 1; i <= NumeroInicial; i++ ) {

				System.out.println(i);
				
			}


			
		}
}