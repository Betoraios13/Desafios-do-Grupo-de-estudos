package mainProgram;

import game.Game;
import printText.Print;

public class Program {

	public static void main(String[] args) {
		
		startProgram();
	
		Game game = new Game();
		game.startGame();
		
		endProgram();
	}
	
		
	private static void startProgram() {
		
		Print.printLineDivision();
		
		Print.printText(Print.spacingLeft(3) + "Maior ou Menor?");
		
		Print.printLineDivision();
		
		Print.printText(Print.spacingLeft(5) + "Feito por: Neurolabs");
	}
	
	private static void endProgram() {
		Print.printLineDivision();
		
		Print.printText(Print.spacingLeft(3) + "Fim de Jogo");
		
		Print.printLineDivision();
		
		Print.printText(Print.spacingLeft(5) + "Programador: José Alberto");
	}
}
