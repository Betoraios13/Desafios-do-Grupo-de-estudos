package game;

import java.util.Random;
import java.util.Scanner;

import printText.Print;

public class Game {
	private Scanner input = new Scanner(System.in);
	private int score = 0;
	
	public void startGame() 
	{
		Print.printBreakLine(1);
		
		Print.printLineDivision();
		
		Print.printText(Print.spacingLeft(3) + "Digite start!");
		
		String answer = input.next();
		
		Print.printLineDivision();
		
		if(answer.equals("start")) {
			inGame();
		}else {
			clearWindow();
			return;
		}
	}
	
	private void inGame() {
		clearWindow();
		
		int currentNumber = generateRandomNumber();
		
		while(true) 
		{	
			forQuit();
			
			Print.printText("O número atual é: " + currentNumber);
			Print.printText("Sua pontuação: " + score);
			question();
			
			String answer = input.next();
			
			int newNumber = generateRandomNumber();
			
			if(answer.equals("end")){
				Print.printText("Você saiu do jogo com " + score + " ponto(s). Até a próxima!");
				break;
			}
			
			if(answer.equals("maior") || answer.equals(">")){
				
				isNumberGreater(currentNumber, newNumber);
				
			}else if(answer.equals("menor") || answer.equals("<")) {
				
				isNumberLess(currentNumber, newNumber);
				
			}else {
				invalidInput();
			}
			
			currentNumber = newNumber;
		}
		
	}
	
	private void question() {
		Print.printText("O próximo número será maior ou menor que este?: ");
		Print.printBreakLine(1);
	}
	
	private void forQuit() {
		Print.printText(Print.spacingLeft(5) + "Digite 'end' para encerrar o jogo");
	}
	
	private void isNumberGreater(int current, int compare) {
		if(compare > current) {
			score += 10;
			Print.printText("✅ Acertou!");
			Print.printBreakLine(1);
			return;
		}
		
		score -= 10;
		Print.printText("❌ Errou.");
		Print.printBreakLine(1);
	}
	
	private void isNumberLess(int current, int compare) {
		if(compare < current) {
			score += 10;
			Print.printText("✅ Acertou!");
			Print.printBreakLine(1);
			return;
		}
		
		score -= 10;
		Print.printText("❌ Errou.");
		Print.printBreakLine(1);
	}
	
	private void invalidInput() {
		Print.printText("Entrada inválida");
		Print.printBreakLine(1);
	}
	
	private void clearWindow() {
		Print.printBreakLine(10);
	}
	
	private int generateRandomNumber() {
		return new Random().nextInt(0, 100);
	}
	
}
