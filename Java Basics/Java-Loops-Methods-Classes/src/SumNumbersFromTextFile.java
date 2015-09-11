import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

// Place your Input.txt file outside the src folder
public class SumNumbersFromTextFile {
    public static void main(String[] args) throws IOException {
        try {
            FileReader fileReader = new FileReader("Input.txt");
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            int sum = 0;
            String line = bufferedReader.readLine();
            while (line != null) {
                sum += Integer.parseInt(line);
                line = bufferedReader.readLine();
            }

            System.out.println(sum);
            bufferedReader.close();
        } catch (FileNotFoundException e) {
            System.out.println("Error");
        }
    }
}