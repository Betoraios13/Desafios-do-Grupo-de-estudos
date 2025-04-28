package main;

import java.util.Scanner;
import printText.Print;
import secure.PasswordFormatter;

public class Main {
	
	public static void result(String[] passwords, String confirmPassword) {
		
		boolean accepted = false;
		
		for(String pass : passwords) {
			if(confirmPassword.equals(pass)) {
				accepted = true;
				break;
			}
		}
		
		if(accepted == true) {
			Print.printText("Senha aceita com sucesso!");
			return;
		}
			
		Print.printText("Senha diferente :(. Reinicie o programa e tente novamente");

	}
	
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		Print.printLineDivision();
		Print.printText("Insira sua nova senha: ");
		
		String password = input.nextLine();
		
		Print.printLineDivision();
		Print.printBreakLine();
		
		Print.printLineDivision();
		Print.printText("SUGESTÕES DE SENHAS MAIS SEGURAS: ");
		Print.printBreakLine();
		
		String reversedPassword = PasswordFormatter.reversedPassword(password);
		Print.printText("Senha invertida: ");
		Print.printText(reversedPassword);
		
		String upperCasePassword = PasswordFormatter.toUpperCase(password);
		Print.printText("Senha em maiúsculo: ");
		Print.printText(upperCasePassword);
		
		String noVowelsCasePassword = PasswordFormatter.noVowels(password);
		Print.printText("Senha sem vogais: ");
		Print.printText(noVowelsCasePassword);
		
		String encryptedPassword = PasswordFormatter.encrypted(password);
		Print.printText("Senha cifrada: ");
		Print.printText(encryptedPassword);

		Print.printBreakLine();
		Print.printLineDivision();
		Print.printText("Confirme sua senha: ");
		String confirmPassword = input.nextLine();
		
		String[]passwords = {password, reversedPassword, upperCasePassword, noVowelsCasePassword, encryptedPassword};
				
		result(passwords, confirmPassword);
		input.close();
	}

}
