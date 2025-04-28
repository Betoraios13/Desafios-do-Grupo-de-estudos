package secure;

public class PasswordFormatter {
	
	public static String reversedPassword(String password) {
		
		StringBuilder newPassword = new StringBuilder();
		
		for(int i = password.length() - 1; i >= 0; i--) {
			newPassword.append(password.charAt(i));
		}
		
		return newPassword.toString();
	}
	
	public static String toUpperCase(String password) {
	
		return password.toUpperCase();
	}
	
	public static String noVowels(String password) {
		return password.replaceAll("[aeiouAEIOU]", "");
	}
	
	public static String encrypted(String password) {
		return password.replace("a", "@")
					   .replace("e", "&")
					   .replace("i", "^")
					   .replace("o", "0")
					   .replace("u", "-");
	}

}
