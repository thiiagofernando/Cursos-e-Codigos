package Operacoes;
import java.util.Scanner;

public class operacoes {

	public static void main(String[] args) {
		//declara as variaveis
		double  PrimeiroValor, SegundoValor,somar,multiplica,
		dividir,subtrair;
		
		//recebe os valores
		Scanner scan = new Scanner(System.in);
		System.out.println("Informe o Primeiro Valor");
		PrimeiroValor = scan.nextFloat();
		System.out.println("Informe o Segundo Valor");
		SegundoValor = scan.nextFloat();

		// realiza as operações
		somar = PrimeiroValor + SegundoValor;
		subtrair = PrimeiroValor - SegundoValor;
		dividir = PrimeiroValor / SegundoValor;
		multiplica = PrimeiroValor * SegundoValor;
		
		// exibe o resultado
		System.out.println(" A Soma de " + PrimeiroValor + " Com " + SegundoValor + " é " + somar );
		System.out.println(" A Subtração de " + PrimeiroValor + " Por " + SegundoValor + " é " + subtrair );
		System.out.println(" A Divisão de " + PrimeiroValor + " Por " + SegundoValor + " é " + dividir );
		System.out.println(" A Multiplicação de " + PrimeiroValor + " Por " + SegundoValor + " é " + multiplica );
	}

}
