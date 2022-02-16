import java.io.PrintStream;
import java.text.MessageFormat;
import java.util.Date;
import java.util.Scanner;


public class HelloWorld {
    public static void main(String[] args) {
//        printTests();
//        readTests();
        parsingTests();
    }

    private static void parsingTests() {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        int n = Integer.parseInt(line.trim());
        System.out.printf("Das erste zeichen ist  %c".formatted(line.charAt(0)));

        //System.out.printf("The Square of %d is %d", n, n * n);
        double d = Double.parseDouble(line);
        System.out.printf("The square of %f is %f", d, d * d);
        System.out.println("The square of %f is %f".formatted(d, d * d));

        PrintStream o = System.out;
        o.println(Double.toString(3.14));
        o.println(Integer.toString(3));
        o.println(Boolean.toString(false));
        o.println(Integer.toHexString(1234));
        o.println(Integer.toBinaryString(1234));


    }
    private static void readTests() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Gib Etwas ein: ");
        //System.out.print();
        String line = scanner.nextLine(); //Console.ReadLine()
        System.out.format("Eingegebene Zeile ist: %s", line);
        int n = scanner.nextInt();
        System.out.println(n * 2);
        n = scanner.nextInt();
        System.out.println(n * 2);
    }


    private static void printTests() {
        System.out.println("Hello World");
        System.out.println("3");
        System.out.println(1);
        System.out.println(true);
        System.out.println(3.125);
        System.out.println(1 + 1);
        System.out.println(1 + 1);

        System.out.format("%d + %d = %d", 1, 1, 2);
        System.out.println();

        System.out.format("%s + %b  %.2f%n", "Felix", true, 3.125);
        System.out.format("%s + %b  %.1f%n %1$s", "Felix", true, 3.859);
        System.out.format("%s + %b  %.1f%n {%3$f + %3$f}", "Felix", true, 3.859);
        //System.out.format("%s + %b  %.1f%n", "Felix", true, 3.859);
        System.out.println();

        String message =  MessageFormat.format("{0, number} + {1, number} = {2, number}", 4, 2, 4+2);
        String anotherMessage =  MessageFormat.format("{0, time} ", new Date());
        System.out.println(message);
        System.out.println(anotherMessage);
        Date someDate = new Date();
        //System.out.format("%t", new Date());
        System.out.printf("%te %<tm", someDate );
        System.out.printf("%te %<tm", someDate );
    }



}


