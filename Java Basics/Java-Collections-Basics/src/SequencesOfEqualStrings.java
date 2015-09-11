import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] elements = scanner.nextLine().split(" ");
        for (int i = 0; i < elements.length; i++) {
            System.out.print(elements[i]);
            while (i < elements.length - 1) {
                if (elements[i].equals(elements[i + 1]) ) {
                    System.out.printf(" %s", elements[i + 1]);
                    i++;
                } else {
                    break;
                }
            }

            System.out.println();
        }
    }
}
