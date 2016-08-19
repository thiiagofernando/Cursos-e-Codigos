public class OperadoresAritimeticos2{

	public static void main(String[] args){

		double MediaNota1 = 3;
		double MediaNota2 = 8;
		double MediaNota3 = 1;

		double MediaFinal = (MediaNota1 + MediaNota2 + MediaNota3)/3;

		if (MediaFinal >= 7) {

			System.out.println("Aluno Aprovado Com Media: " + MediaFinal);
			
		}else if (MediaFinal >= 5 && MediaFinal < 7 ) {
			
			System.out.println("Aluno de Prova Final com Media: " + MediaFinal);

		}else if (MediaFinal < 5 ) {
			
			System.out.println("Aluno Reprovado com Media: " + MediaFinal);

		}


	}
}