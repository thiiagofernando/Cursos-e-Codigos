import java.util.Scanner;

public class Escopo{

	public static void main(String[] args){

		Scanner entrada = new Scanner(System.in);

		System.out.println("Idade: ");
		int idade = entrada.nextInt();

		boolean podeDirigir = idade >= 18;
		String nomePai = "";

		if (!podeDirigir) {

			System.out.println("Nome do Pai: ");

			nomePai = entrada.next();
			
		}
		System.out.println("Voce pode dirigir? " );

		if (podeDirigir) {

			System.out.println("Sim, claro");
			
		}else {
			System.out.println("Nao, se fizer isso , seu pai " + nomePai + " Vai preso ");
		}
	}
}