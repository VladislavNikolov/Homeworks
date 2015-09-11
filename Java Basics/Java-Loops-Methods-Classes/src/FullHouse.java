public class FullHouse {
    public static void main(String[] args) {
        char club = '\u2663';
        char diamond = '\u2666';
        char heart = '\u2764';
        char spade = '\u2660';
        int numberOfFullHouses = 0;
        for (Integer i = 2; i <= 14; i++) {
            String faceValueForSets = getCardFaceValue(i);
            String[] allSets = new String[]{
                    String.format("%1$s%2$s %1$s%3$s %1$s%4$s", faceValueForSets, club, diamond, heart),
                    String.format("%1$s%2$s %1$s%3$s %1$s%4$s", faceValueForSets, club, diamond, spade),
                    String.format("%1$s%2$s %1$s%3$s %1$s%4$s", faceValueForSets, club, heart, spade),
                    String.format("%1$s%2$s %1$s%3$s %1$s%4$s", faceValueForSets, diamond, heart, spade)
            };
            for (Integer j = 2; j <= 14; j++) {
                if (j != i) {
                    String faceValueForPairs = getCardFaceValue(j);
                    String[] allPairs = new String[]{
                            String.format("%1$s%2$s %1$s%3$s", faceValueForPairs, club, diamond),
                            String.format("%1$s%2$s %1$s%3$s", faceValueForPairs, club, heart),
                            String.format("%1$s%2$s %1$s%3$s", faceValueForPairs, club, spade),
                            String.format("%1$s%2$s %1$s%3$s", faceValueForPairs, diamond, heart),
                            String.format("%1$s%2$s %1$s%3$s", faceValueForPairs, diamond, spade),
                            String.format("%1$s%2$s %1$s%3$s", faceValueForPairs, heart, spade)
                    };
                    printFullHouses(allSets, allPairs);
                    numberOfFullHouses += 24;
                    System.out.println();
                }
            }
        }

        System.out.printf("%d full houses", numberOfFullHouses);
    }

    private static String getCardFaceValue(Integer i) {
        String faceValue = "";
        if (i >= 2 && i <= 10) {
            faceValue = i.toString();
        } else {
            switch (i) {
                case 11:
                    faceValue = "J";
                    break;
                case 12:
                    faceValue = "Q";
                    break;
                case 13:
                    faceValue = "K";
                    break;
                case 14:
                    faceValue = "A";
                    break;
            }
        }

        return faceValue;
    }

    private static void printFullHouses(String[] allSets, String[] allPairs) {
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 6; j++) {
                System.out.printf("(%s %s) ", allSets[i], allPairs[j]);
            }
        }
    }
}
