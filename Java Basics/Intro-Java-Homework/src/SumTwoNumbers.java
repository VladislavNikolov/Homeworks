import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        System.out.println("Enter two integers:");

        Scanner scanner = new Scanner(System.in);
        int firstNumber = scanner.nextInt();
        int secondNumber = scanner.nextInt();

        System.out.println(firstNumber + secondNumber);
    }
}
