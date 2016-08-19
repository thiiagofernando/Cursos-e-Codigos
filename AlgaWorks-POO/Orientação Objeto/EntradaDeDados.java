import java.util.Scanner;
import java.util.Locale;

public class EntradaDeDados{

	public static void main(String[] args){

		// Configura Locale explicitamente para Brasil:
		
		Locale.setDefault(new Locale("pt", "BR"));

		Scanner entrada = new Scanner(System.in);

		System.out.print("Digite Seu Nome: ");
		String nome = entrada.nextLine();

		System.out.println("Oi " + nome);

		System.out.print("Peso: ");
		int peso = entrada.nextInt();


		System.out.print("Altura: ");
		Double altura = entrada.nextDouble();

		double imc = peso / (altura * altura);

		System.out.println("IMC de  " + nome + ": " + imc);
	}
}