using System;

// REQUIRES .NET VERSION 7
					
public class Program
{
	public static void Main()
	{
		String text = "The quick brown fox jumps over the lazy dog";
		String new_text = "";
		
		// General function for reversing a string.
		static String reverseWord(String current_word) {
			String new_word = "";
				for (int y = current_word.Length - 1; y >= 0; y--) {
					new_word = new_word + current_word[y];
				}
			return new_word;
		}
		
		// Loop through entire text string.
		String word = "";
		for (int x = 0; x < text.Length; x++) {
			// Adds the final word to the new_text
			if (x == text.Length - 1) {
				String new_word = reverseWord(word + text[x]);
				new_text = new_text + new_word + " ";
				word = "";
			} 
			// Adds characters to the current word if space character is NOT detected.
			else if (text[x] != ' ') {
				word = word + text[x];
			} 
			// Reverses the current word when the space character is detected.
			else {
				String new_word = reverseWord(word);
				new_text = new_text + new_word + " ";
				word = "";
			}
		}
		Console.Write(new_text);		
	}
}