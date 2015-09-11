import java.util.Scanner;

public class AngleUnitConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfQueries = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < numberOfQueries; i++) {
            String[] commandArgs = scanner.nextLine().split(" ");
            double numberToConvert = Double.parseDouble(commandArgs[0]);
            String measure = commandArgs[1];
            if (measure.equals("rad")) {
                double result = convertRadToDeg(numberToConvert);
                System.out.printf("%1.6f deg", result);
            } else {
                double result = convertDegToRad(numberToConvert);
                System.out.printf("%1.6f rad", result);
            }

            System.out.println();
        }
    }

    private static double convertRadToDeg(double numberToConvert) {
        double result = numberToConvert * (180 / Math.PI);
        return result;
    }

    private static double convertDegToRad(double numberToConvert) {
        double result = numberToConvert * (Math.PI / 180);
        return result;
    }
}
