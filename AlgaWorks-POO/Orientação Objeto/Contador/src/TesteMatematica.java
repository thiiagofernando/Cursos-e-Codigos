public class TesteMatematica {

	public static void main(String[] args) {
		
			int numeroFibonacci = MatematicaUtil.calcularFibonacci(8);
			System.out.println("N�mero de Fibonacci da posi��o 8: " + numeroFibonacci);
			
			double areaCirculo = AreaCirculoUtil.calcularAreaCirculo(104.8);
			System.out.println("�rea do c�rculo: " + areaCirculo);
	}
}