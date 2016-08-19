import java.util.Scanner;
import java.util.Locale;

class EntradaDeDados2 {
	public static void main(String[] args) {
		// Configura Locale explicitamente para Brasil:
		Locale.setDefault(new Locale("pt", "BR"));
		
		Scanner entrada = new Scanner(System.in);

		System.out.println("");
		System.out.print("Digite seu nome: ");
		String nome = entrada.nextLine();

		System.out.println("");
		System.out.print("Digite seu peso, em Kg: ");
		double peso = entrada.nextDouble();

		System.out.println("");
		System.out.print("Digite sua altura em m: ");
		double altura = entrada.nextDouble();

		double imc = peso / (altura * altura);

		System.out.println("----------------------------------");
		System.out.println(nome + ", seu IMC é de " + imc);
	}
}