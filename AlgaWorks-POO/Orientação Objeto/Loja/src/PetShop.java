
public class PetShop {
	
	public static void main(String[] args){
		Cachorro cachorro = new Cachorro();
		
		cachorro.nome = "Bidu";
		cachorro.idade =  1;
		cachorro.raca = "Boxer";
		cachorro.sexo = 'M';
		
		System.out.println("Nome do Cachorro: " + cachorro.nome);
		System.out.println("Idade do Cachorro: " + cachorro.idade);
		System.out.println("Raça do Cachorro: " + cachorro.raca);
		System.out.println("Sexo do Cachorro: " + cachorro.sexo);
		
		Dono dono = new Dono();
		
		dono.NomeDono = "Thiago";
		
		System.out.println("Nome do Dono é: " + dono.NomeDono);
	}

}
