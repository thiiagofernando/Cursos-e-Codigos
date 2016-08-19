import java.util.Scanner;

public class MultaVeiculo{

	public static void main(String[] args){

		Scanner entrada = new Scanner(System.in);

		System.out.println("Tipo de Veiculo (passeio, caminhao)");
		String tipoVeiculo = entrada.nextLine();

		System.out.println("Velocidade Maxima na Via ");
		int velocidadeMaxima = entrada.nextInt();

		System.out.println("Velocidade Veiculo");
		int velocidadeVeiculo = entrada.nextInt();

		if (tipoVeiculo.equals("passeio") && velocidadeVeiculo > velocidadeMaxima * 1.1) {
			
			System.out.println("MULTA");
		}else if (tipoVeiculo.equals("caminhao") && velocidadeVeiculo > velocidadeMaxima * 1.05) {
			
			System.out.println("MULTA");
		}


	}
}