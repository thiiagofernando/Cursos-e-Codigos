public class PrecoMedioBombom{

	public static void main(String[] args){

		// preço das ultimas 3 vendas realizadas
		int preco1 = 5;
		int preco2 = 8;
		int preco3 = 12;

		int mediaPrecos = (preco1 + preco2 + preco3)/3;

		System.out.println("\"Sistema de controle de precos\"");
		System.out.println("Preco 1: " + preco1);
		System.out.println("Preco 2: " + preco2);
		System.out.println("Preco 3: " + preco3);

		System.out.println("Media dos Precos: " + mediaPrecos);


	}
}