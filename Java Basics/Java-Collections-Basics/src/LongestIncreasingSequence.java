import java.util.Scanner;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] numbersAsStrings = scanner.nextLine().split(" ");
        int[] allNumbbers = new int[numbersAsStrings.length];
        for (int i = 0; i < allNumbbers.length; i++) {
            allNumbbers[i] = Integer.parseInt(numbersAsStrings[i]);
        }

        int startIndexOfBestSequence = 0;
        int longestSequence = 1;
        for (int i = 0; i < allNumbbers.length; i++) {
            int currentIndex = i;
            int currentLongestSequence = 1;
            System.out.print(allNumbbers[i] + " ");
            while (i + 1 < allNumbbers.length && allNumbbers[i] < allNumbbers [i + 1]) {
                System.out.print(allNumbbers[i + 1] + " ");
                i++;
                currentLongestSequence++;
                if (currentLongestSequence > longestSequence) {
                    startIndexOfBestSequence = currentIndex;
                    longestSequence = currentLongestSequence;
                }
            }

            System.out.println();
        }

        System.out.print("Longest: ");
        for (int i = startIndexOfBestSequence; i < startIndexOfBestSequence + longestSequence; i++) {
            System.out.print(allNumbbers[i] + " ");
        }
    }
}
