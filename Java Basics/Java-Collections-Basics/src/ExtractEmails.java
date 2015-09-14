import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmails {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        String pattern =
                "(\\w+[\\.\\-\\_]?(?:\\w+[\\.\\-\\_]?)*\\w+@\\w+(?:\\-\\w+)*\\.\\w+(?:\\-\\w+)*(?:\\.\\w+(\\-\\w+)*)*)";
        Pattern regex = Pattern.compile(pattern);
        Matcher matcher = regex.matcher(text);
        while (matcher.find()) {
            System.out.println(matcher.group());
        }
    }
}
