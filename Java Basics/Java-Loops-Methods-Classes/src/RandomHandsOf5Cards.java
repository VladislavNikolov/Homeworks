import java.util.Random;
import java.util.Scanner;

public class RandomHandsOf5Cards {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfHands = scanner.nextInt();
        String[] allCardFaces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        char[] allCardSuits = new char[]{'\u2663', '\u2666', '\u2764', '\u2660'};
        Random randomGenerator = new Random();
        for (int i = 0; i < numberOfHands; i++) {
            for (int j = 0; j < 5; j++) {
                int cardFace = randomGenerator.nextInt(allCardFaces.length);
                int cardSuit = randomGenerator.nextInt(allCardSuits.length);
                System.out.printf("%s%s ", allCardFaces[cardFace], allCardSuits[cardSuit]);
            }

            System.out.println();
        }
    }
}
