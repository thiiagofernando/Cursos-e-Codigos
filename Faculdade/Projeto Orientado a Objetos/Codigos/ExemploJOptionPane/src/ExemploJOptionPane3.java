import javax.swing.JOptionPane;
import javax.swing.UIManager;


public class ExemploJOptionPane3 {

	public static void main(String[] args) throws Exception {
		UIManager.setLookAndFeel(UIManager.getCrossPlatformLookAndFeelClassName());
		
		Object[] opcoes = {"Sim", "N�o", "Sim, com e-mail"};
		
		int opcao = JOptionPane.showOptionDialog(null, "Voc� gostaria de finalizar o cadastro?"
						, "Confirma��o", JOptionPane.YES_NO_CANCEL_OPTION, JOptionPane.QUESTION_MESSAGE
						, null, opcoes, opcoes[2]);
		
		System.out.println("Op��o selecionada: " + opcao);
		
		if (opcao == 1) {
			// ...
		}
		
	}
	
}