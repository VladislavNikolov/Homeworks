import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] elements = scanner.nextLine().split(" ");
        int highestSequence = 1;
        int indexOfHighestSequence = 0;
        for (int i = 0; i < elements.length; i++) {
            int counter = 1;
            int currentIndex = i;
            while (i < elements.length - 1) {
                if (elements[i].equals(elements[i + 1]) ) {
                    counter++;
                    i++;
                    if (counter > highestSequence) {
                        highestSequence = counter;
                        indexOfHighestSequence = currentIndex;
                    }
                } else {
                    break;
                }
            }
        }

        for (int i = indexOfHighestSequence; i < indexOfHighestSequence + highestSequence; i++) {
            System.out.print(elements[i] + " ");
        }
    }
}
