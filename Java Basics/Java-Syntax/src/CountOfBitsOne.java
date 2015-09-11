import java.util.Scanner;

public class CountOfBitsOne {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = scanner.nextInt();
        char[] binaryNumber = Integer.toBinaryString(number).toCharArray();
        int numberOfOnes = 0;
        for (int i = 0; i < binaryNumber.length; i++) {
            if (binaryNumber[i] == '1') {
                numberOfOnes++;
            }
        }

        System.out.println(numberOfOnes);
    }
}
