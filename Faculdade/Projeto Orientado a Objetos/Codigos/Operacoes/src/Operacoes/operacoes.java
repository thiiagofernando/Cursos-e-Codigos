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

		// realiza as opera��es
		somar = PrimeiroValor + SegundoValor;
		subtrair = PrimeiroValor - SegundoValor;
		dividir = PrimeiroValor / SegundoValor;
		multiplica = PrimeiroValor * SegundoValor;
		
		// exibe o resultado
		System.out.println(" A Soma de " + PrimeiroValor + " Com " + SegundoValor + " � " + somar );
		System.out.println(" A Subtra��o de " + PrimeiroValor + " Por " + SegundoValor + " � " + subtrair );
		System.out.println(" A Divis�o de " + PrimeiroValor + " Por " + SegundoValor + " � " + dividir );
		System.out.println(" A Multiplica��o de " + PrimeiroValor + " Por " + SegundoValor + " � " + multiplica );
	}

}
