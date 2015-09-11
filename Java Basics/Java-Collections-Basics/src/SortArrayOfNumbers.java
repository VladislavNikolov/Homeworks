import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfNumbers = scanner.nextInt();
        int[] allNumbers = new int[numberOfNumbers];
        for (int i = 0; i < numberOfNumbers; i++) {
            allNumbers[i] = scanner.nextInt();
        }
        Arrays.sort(allNumbers);
        for (int i = 0; i < numberOfNumbers; i++) {
            System.out.printf("%d ", allNumbers[i]);
        }
    }
}
