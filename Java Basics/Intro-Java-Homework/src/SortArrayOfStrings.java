import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {
        System.out.println("Enter an integer:");
        Scanner scanner = new Scanner(System.in);
        int numberOfStrings = scanner.nextInt();

        System.out.println(String.format("Enter %s strings", numberOfStrings));
        String[] allStrings = new String[numberOfStrings];
        for (int i = 0; i < numberOfStrings; i++) {
            allStrings[i] = scanner.next();
        }

        Arrays.sort(allStrings);
        System.out.println(Arrays.toString(allStrings));
    }
}
