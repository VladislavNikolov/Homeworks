import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class CardFrequences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");

        Map<String, Integer> cardsByCount = new LinkedHashMap<>();
        for (String word : input) {
            String card = word.substring(0, word.length() - 1);
            Integer count = cardsByCount.get(card);
            if (count == null) {
                count = 0;
            }
            cardsByCount.put(card, count + 1);
        }

        for (Map.Entry<String, Integer> stringIntegerEntry : cardsByCount.entrySet()) {
            double frequency = ((double)stringIntegerEntry.getValue()*100)/input.length;
            System.out.printf("%s -> %.2f%%", stringIntegerEntry.getKey(), frequency);
            System.out.println();
        }
    }
}