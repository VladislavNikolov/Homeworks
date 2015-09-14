import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        Pattern regex = Pattern.compile("\\w+");
        Matcher matcher = regex.matcher(text);
        TreeMap<String, Integer> uniqueWords = new TreeMap<>();
        while (matcher.find()) {
            String key = matcher.group();
            if (!uniqueWords.containsKey(key)) {
                uniqueWords.put(key, 1);
            } else {
                uniqueWords.put(key, uniqueWords.get(key) + 1);
            }
        }

        int maxValue = 0;
        for (Integer integer : uniqueWords.values()) {
            if (integer > maxValue) {
                maxValue = integer;
            }
        }

        for (Map.Entry<String, Integer> stringIntegerEntry : uniqueWords.entrySet()) {
            if (stringIntegerEntry.getValue() == maxValue) {
                System.out.println(stringIntegerEntry.getKey() + " -> " + maxValue + " times");
            }
        }
    }
}
