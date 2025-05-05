package printText;

public class Print {
	public static void printLineDivision() {
		System.out.println("=============================================================");
	}
	
	public static void printBreakLine(int numberOfLines) {
		
		for(int i = 0; i < numberOfLines; i++)
			System.out.println("\n");
	}
	
	public static void printText(String text) {
		System.out.println(text);
	}
	
	public static String spacingLeft(int numberOfSpaces) {
		StringBuilder stringBuilder = new StringBuilder();
		
		for(int i = 0; i < numberOfSpaces; i++)
			stringBuilder.append("\t");
		
		return stringBuilder.toString();
	}
}
