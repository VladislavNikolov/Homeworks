import java.util.Scanner;
import java.util.TreeSet;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        Pattern regex = Pattern.compile("\\w+");
        Matcher matcher = regex.matcher(text);
        TreeSet<String> uniqueWords = new TreeSet<>();
        while (matcher.find()) {
            uniqueWords.add(matcher.group());
        }

        System.out.print(String.join(" ", uniqueWords));
    }
}
