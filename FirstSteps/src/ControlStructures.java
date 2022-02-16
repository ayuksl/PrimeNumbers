import java.util.Arrays;
import java.util.Scanner;

public class ControlStructures {
    public static void main(String[] args) {

//     boolean a = isInterestingApplicant(Gender.Female, 25, 7);
//    System.out.printf("The applicant is interesting %b ", a);
        //bonus();
        //getCharacterType();
//        System.out.printf("The gender is: %s", f(Gender.Unknown));
        //forceUserInput("ja");
        //System.out.println( getNumberFromUser(4, 6));


        //genders();

        //System.out.printf("%d%n", computeSum(new int[]{1, 2, 3, 4, 5}));

        //minMaxAvg(new double[]{ 85, 56, 87}, 0, 0);

    }

    private static double min(double[] numbers) {
        double min = numbers[0];

        for (int i = 0; i < numbers.length; ++i) {
                if (numbers[i] < min) {
                    min = numbers[i];
                }
        }

        return min;
    }

    private static double numbersMax(double[] numbers) {

        double max = numbers[0];
        for (int i = 0; i < numbers.length; ++i) {
            if (numbers[i] > max) {
                max = numbers[i];

            }
        }
        return max;
    }



    private static double Min(double[] numbers) {

        double min = Min(numbers);



        return min;

    }




//    private static void genders() {
//        String[] genders = {
//                "männlich", "weiblich", "divers"
//        };
//        String choice =        getOneOf("Gib Geschlecht ein: ", genders );
//        System.out.printf("Dein gewähltes Geschlecht ist %s%n", choice);
//    }
//


    private static int computeSum(int[] numbers) {
        int sum = 0;
        for (int i = 0; i < numbers.length; ++i) {
            sum += numbers[i];
            //sum = sum + numbers[i];
        }
        return sum;

    }

    private static String getNumberFromUser2(String prompt, String[] validInputs) {

        String input;



        Scanner scanner = new Scanner(System.in);

        boolean isValid = false;

        do {
            System.out.printf("%s: ", prompt);
            input = scanner.nextLine();
            for (String validInput : validInputs) {
                if (validInput.equalsIgnoreCase(input)) {
                    isValid = true;
                    break;
                }
            }
        } while (!isValid);
        return input;

    }

//    private static String getOneOf(String prompt, String[] validInputs) {
//        String input;
//        Scanner scanner = new Scanner(System.in);
//        boolean isValid = false;
//
//
//        do {
//            System.out.printf("%s: ", prompt);
//            input = scanner.nextLine();
//            for (String validInput : validInputs) {
//                if (! (a <= Integer.parseInt(line.trim()) && Integer.parseInt(line.trim()) <= b && b >= a )  ) {
//                    isValid = true;
//                    break;
//                }
//            }
//        } while (!isValid);
//        return input;
//    }

    private static int getNumberFromUser(int a, int b) {

        String line = new String();



        Scanner scanner = new Scanner(System.in);

        line = scanner.nextLine();

        while (! (a <= Integer.parseInt(line.trim()) && Integer.parseInt(line.trim()) <= b && b >= a )  ) {
            System.out.printf("Gib eine nummer ein:");
            line = scanner.nextLine();
        }
         return Integer.parseInt(line.trim());

    }
    private static void forceUserInput(String expected) {
        String line = "";
        Scanner scanner = new Scanner(System.in);


        while (!line.trim().equals(expected)) {
            System.out.printf("Gib etwqs ein:");
            line = scanner.nextLine();

        }
        System.out.println("The output is: successful");
    }

    private static String f(Gender s) {


        String gender = new String();
        switch (s) {
            case Male:
                return gender = "männlich";


            case Female:
                return gender = "weiblich";
            case Diverse:
                return gender = "divers";
            default:
                return gender = "unknown";

        }



    }

        private static CharacterType getCharacterType(char c) {
        switch (c) {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                return CharacterType.Digit;
            case '.':
            case ':':
            case ',':
            case ';':
                return CharacterType.Punctuation;
            case 'a':
            case 'b':
                return CharacterType.Letter;

            default:
                System.out.printf("Unknown character %c found%n", c);
                return CharacterType.Unknown;

        }
    }

//        public static void bonus(Gender.Female, 25, 7) {
//        double bonus = computeBonus(5000);
//        System.out.printf("Bonus von 5000 ist %.2f%n", bonus);
//        bonus = computeBonus(10000);
//        System.out.printf("Bonus von 10000 ist %.2f%n", bonus);
//        bonus = computeBonus(30000);
//        System.out.printf("Bonus von 30000 ist %.2f%n", bonus);
//    }


        private static boolean isInterestingApplicant (Gender gender,int age, int expertise){
            if ((gender == Gender.Male) && (age <= 30)
                    || (gender == Gender.Female) && (age >= 20) && (expertise >= 5)
            ) {
                return true;
            }
            return false;
        }

        private static double computeBonus ( double revenue){
            final double smallBonus = 0.05;
            final double bigBonus = 0.15;


            if (revenue < 0) {
                throw new IllegalArgumentException("Revenue < 0!!!");
            }
            if (revenue < 10_000) {
                return 0;
            } else if (revenue < 20_000) {
                //10_000 <= revenue < 20_000
                return revenue * smallBonus;
            } else {

                return revenue * bigBonus;
            }

        }


    }

