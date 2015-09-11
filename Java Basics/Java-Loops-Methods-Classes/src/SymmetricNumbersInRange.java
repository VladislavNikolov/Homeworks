import java.util.*;

public class SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int start = scanner.nextInt();
        int end = scanner.nextInt();
        List<Integer> symmetricNumbers = new ArrayList<>();
        for (Integer i = start; i <= end; i++) {
            if (CheckIfNumberIsSymmetrical(i)) {
                symmetricNumbers.add(i);
            }
        }

        for (int i = 0; i < symmetricNumbers.size(); i++) {
            System.out.print(symmetricNumbers.get(i) + " ");
        }
    }

    // Cannot call .toString on primitive data types.
    // That is why we use Integer class instead of int
    private static boolean CheckIfNumberIsSymmetrical(Integer number) {
        String numberAsString = number.toString();
        String leftPart, rightPart;
        int numberLength = numberAsString.length();
        if (numberLength == 2) {
            leftPart = numberAsString.substring(0, 1);
            rightPart = numberAsString.substring(1);
        }
        else if (numberLength == 3) {
            leftPart = numberAsString.substring(0, 1);
            rightPart = numberAsString.substring(2);
        }
        else {
            return true;
        }

        if (leftPart.equals(rightPart)) {
            return true;
        }

        return false;
    }
}
