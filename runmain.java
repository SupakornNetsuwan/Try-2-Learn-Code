import java.util.Scanner;
public class runmain {

    public static void main(String[] args) {
        char input;
        Scanner reader = new Scanner(System.in);
        System.out.println("D = Distance Calculator");
        System.out.println("S = Speed Calculator");
        System.out.println("T = Time Calculator");
        System.out.print("Enter Mode : ");
        input = reader.next().charAt(0);
        finalTestJava01 run = new finalTestJava01(input);
    }
}