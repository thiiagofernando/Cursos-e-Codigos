import java.util.Scanner;

public class OperadoTernario{

	public static void main(String[] args){

		Scanner entrada = new Scanner(System.in); 

		System.out.println("Informe Sua Idade: ");
		int idade = entrada.nextInt();

		//                  expressao boolena     valor caso verdadeiro            valor caso falso
		String indicacao = (idade >= 18)  ?      "Adulto"                   :      (idade <= 12 ? "Crinaca" : "Adolescente");

/*
		if (idade >= 19) {

			System.out.println("Resultado: " + indicacao);
			
		}else {

			System.out.println("Resultado: " + indicacao);
		}*/
		System.out.println("Resultado: " + indicacao);
	}
}