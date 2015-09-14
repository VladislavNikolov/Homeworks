import java.util.ArrayList;
import java.util.Scanner;

public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] charArray = scanner.nextLine().replaceAll(" ", "").toCharArray();
        ArrayList<Character> listOne = new ArrayList<>();
        for (int i = 0; i < charArray.length; i++) {
            listOne.add(charArray[i]);
        }

        charArray = scanner.nextLine().replaceAll(" ", "").toCharArray();
        ArrayList<Character> listTwo = new ArrayList<>();
        for (int i = 0; i < charArray.length; i++) {
            listTwo.add(charArray[i]);
        }

        // listThree is used to add a missing char in listOne that is repeated more than once in listTwo
        ArrayList<Character> listThree = new ArrayList<>();
        for (int i = 0; i < listTwo.size(); i++) {
            if (!listOne.contains(listTwo.get(i))) {
                listThree.add(listTwo.get(i));
            }
        }

        for (int i = 0; i < listThree.size(); i++) {
            listOne.add(listThree.get(i));
        }

        for (int i = 0; i < listOne.size(); i++) {
            System.out.print(listOne.get(i) + " ");
        }
    }
}
