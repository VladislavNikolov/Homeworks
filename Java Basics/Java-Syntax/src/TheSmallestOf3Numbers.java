import java.util.Scanner;

public class TheSmallestOf3Numbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double firstNumber = scanner.nextDouble();
        double secondNumber = scanner.nextDouble();
        double thirdNumber = scanner.nextDouble();
        double smallestNumber;
        if (firstNumber <= secondNumber) {
            if (firstNumber <= thirdNumber) {
                smallestNumber = firstNumber;
            } else {
                smallestNumber = thirdNumber;
            }
        } else {
            if (secondNumber <= thirdNumber) {
                smallestNumber = secondNumber;
            } else {
                smallestNumber = thirdNumber;
            }
        }

        System.out.println(smallestNumber);
    }
}
