import java.util.Scanner;

public class PointsInsideFigure {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double x = scanner.nextDouble();
        double y = scanner.nextDouble();

        boolean xInside = false;
        boolean yInside = false;

        if (6.0 <= y && y <= 8.5) {
            xInside = 12.5 <= x && x <= 22.5;
            yInside = true;
        } else if (8.5 < y && y <= 13.5) {
            xInside = (12.5 <= x && x <= 17.5) || (20.0 <= x && x <= 22.5);
            yInside = true;
        }

        if (xInside && yInside) {
            System.out.println("Inside");
        } else {
            System.out.println("Outside");
        }



    }
}
