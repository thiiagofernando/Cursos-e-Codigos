package CALC;

import java.util.Scanner;

public class CalculadorCase {

	public static void main(String[] args) {
		
		double  PrimeiroValor, SegundoValor,somar,multiplica,dividir,subtrair;
		int op;
		
		Scanner scan = new Scanner(System.in);
		System.out.println("Informe o Primeiro Valor");
		PrimeiroValor = scan.nextFloat();
		System.out.println("Informe o Segundo Valor");
		SegundoValor = scan.nextFloat();
		
		System.out.println("Opera��es Disponiveis");
		System.out.println("1 - Soma  2- Subtra��o");
		System.out.println("3 - Multiplica��o  4- Divis�o");
		System.out.println("Informe a Opera��o");
		op = scan.nextInt();
		
		
		switch (op) {
		case 1:
			System.out.println("A soma dos Valores � :" + (PrimeiroValor + SegundoValor));
			break;
		
		case 2:
			System.out.println("A subtra��o dos Valores � :" + (PrimeiroValor - SegundoValor));
			break;
			
		case 3:
			System.out.println("A multiplica��o dos Valores � :" + (PrimeiroValor * SegundoValor));
			break;
			
		case 4:
			System.out.println("A divis�o dos Valores � :" + (PrimeiroValor / SegundoValor));
			break;

		default:
			System.out.println("Opera��o Invalida");
			break;
		}

	}

}
