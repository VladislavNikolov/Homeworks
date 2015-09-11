import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;

public class DaysBetweenTwoDates {
    public static void main(String[] args) throws ParseException {
        Scanner scanner = new Scanner(System.in);
        String firstDateAsString = scanner.nextLine();
        String secondDateAsString = scanner.nextLine();
        DateFormat format = new SimpleDateFormat("dd-MM-yyyy");
        Date firstDate = format.parse(firstDateAsString);
        Date secondDate = format.parse(secondDateAsString);
        long difference = getDateDifference(firstDate, secondDate, TimeUnit.DAYS);
        System.out.println(difference);
    }

    public static long getDateDifference(Date date1, Date date2, TimeUnit timeUnit) {
        long diffInMillies = date2.getTime() - date1.getTime();
        return timeUnit.convert(diffInMillies, TimeUnit.MILLISECONDS);
    }
}
