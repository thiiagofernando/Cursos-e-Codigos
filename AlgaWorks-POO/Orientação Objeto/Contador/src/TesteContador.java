
public class TesteContador {

	public static void main(String[] args) {
		contador c = new contador();
		c.incrementar();
		System.out.println(contador.count);
		
		contador.count++;
		System.out.println(c.count);

	}

}
