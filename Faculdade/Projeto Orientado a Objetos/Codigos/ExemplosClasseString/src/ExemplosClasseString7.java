
public class ExemplosClasseString7 {

	public static void main(String[] args) {
		String s = "curso_online_de_desenvolvimento_de_software";
		
		String[] array  = s.split("_");
		for (int i = 0; i < array.length; i++) {
			System.out.println("[" + i + "]=" + array[i]);
		}
	}

}
