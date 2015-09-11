import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = scanner.nextInt();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();
        String hex = Integer.toHexString(a).toUpperCase();
        String binaryUnpadded = Integer.toBinaryString(a);
        String binaryPadded = "0000000000".substring(binaryUnpadded.length()) + binaryUnpadded;

        System.out.printf("|%1$-10s|%2$s|%3$10.2f|%4$-10.3f|", hex, binaryPadded, b, c);
    }
}
