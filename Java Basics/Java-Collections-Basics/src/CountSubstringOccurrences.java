import java.util.Scanner;

public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        String word = scanner.nextLine().toLowerCase();
        int currentIndex = text.indexOf(word);
        int wordCounter = 0;
        while (currentIndex != -1) {
            wordCounter++;
            currentIndex = text.indexOf(word, currentIndex + 1);
        }

        System.out.println(wordCounter);
    }
}
