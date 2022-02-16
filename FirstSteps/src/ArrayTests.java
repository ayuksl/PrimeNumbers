import java.util.Arrays;
public class ArrayTests {
    public static void main(String[] args) {
//        String[] names = new String[]{"felix", "hamit", "lucy"};
//        String[] animals = {"cat", "dog", "fish", "mouse"};
//        System.out.println(names.length);
//        System.out.println(animals.length);
//        int comparison = Arrays.compare(names, animals);
//        String[] someNames = Arrays.copyOf(names,  5);
//        System.out.println(Arrays.toString(someNames));
//
//        String[] someAnimals = Arrays.copyOfRange(animals,  1, 3);
//        System.out.println(Arrays.toString(someAnimals));
//        int[] ones = new int[100];
////        Arrays.fill(ones, 5);
////        System.out.println(Arrays.toString((ones, 10)));
//        int[] squares = new int[10];
//        Arrays.setAll(squares, i -> i*i);
//        System.out.println(Arrays.toString(squares));

//        int[] numbers = {3,1,5,7};
//        Arrays.sort(numbers, (n1, n2) -> Integer.compare((int)n2, (int)n1));
//        System.out.println(Arrays.toString(squares));
//
        String word = "Hallao";
        char letter = 'a';
       PrintAllIndices(word, letter);



    }
    private static void PrintAllIndices(String word, char letter) {
        String  a = word;

        int z = word.indexOf(letter);
        int[] x =  new int[];
        z +=  word.indexOf(letter);
        System.out.println(z);

    }
}


