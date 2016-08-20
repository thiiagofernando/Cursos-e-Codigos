
public class ExemplosClasseString {

	public static void main(String[] args) {
		String nome = "Thiago";
		System.out.println(nome.toUpperCase());
		System.out.println(nome);
		
		nome = nome.toUpperCase();
		System.out.println(nome);
		//------------------------------
		
		String s1 = "Thiago";
		String s2 = "Thiago";
		System.out.println("S2 == S1 ? " +  (s2 == s1));
		
		String s3 = new String("Thiago");
		System.out.println("S3 == S1 ? " +  (s3 == s1));
		
		System.out.println("s3.equals(s2)? " + (s3.equals(s2)));
		System.out.println("s3.equals(s1)? " + (s3.equals(s1)));
		
		String s4= "ThIaGO";
		System.out.println("s1.equals(s4) ? " + (s1.equals(s4)));
		System.out.println("s1.equalsIgnoreCase(s4) ? " + (s1.equalsIgnoreCase(s4)));

		
		
	}

}
