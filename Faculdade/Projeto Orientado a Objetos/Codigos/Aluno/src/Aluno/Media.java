package Aluno;

import java.util.Scanner;

public class Media {

	public static void main(String[] args) {
		double nota, media1, media2;
		
		int faltas;
		
		Scanner scan = new Scanner(System.in);
		System.out.println("Informe a primeira nota");
		media1 = scan.nextDouble();
		
		System.out.println("Informe a segunda nota");
		media2 = scan.nextDouble();
		
		nota = (media1 + media2)/2;
		
		System.out.println("Informe o Numero de faltas");
		faltas = scan.nextInt();
		
		
		
		if (nota >= 6 && faltas < (20 * 0.25)) {
			
			System.out.println("Aluno Aprovado Media " + nota + " Faltas " + faltas);
		}
		if (nota < 6 && faltas > (20 * 0.25)) {
			
			System.out.println("Aluno Reprovado por media e Falta  "  +  " Media "  + nota + " Faltas " + faltas);
		}
		if (nota >= 6 && faltas > (20 * 0.25)) {
			
			System.out.println("Aluno Reprovado Por faltas " + " Total de Faltas " + faltas + " Media " + nota);
			
		}
		if (nota < 6 && faltas < (20 * 0.25)) {
			
			System.out.println("Aluno Reprovado Por Media " + " Media " + nota + " Falta " + faltas);
			
		}else{
			System.out.println("Falha do Sistema, reinicie o computador");
		}


	}

}
