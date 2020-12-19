import java.util.Scanner;

public class simpleArray {

    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        Scanner notreader = new Scanner(System.in);
        System.out.print("How many city you want to go? : ");
        int city = notreader.nextInt();
        String cityName[] = new String[city];

        System.out.println("Enter City Name : ");
        for (int i = 0; i < city; i++) { 
                System.out.print("[" + (i + 1) + "/" + city + "] : ");
                cityName[i] = reader.nextLine();
            }

        System.out.println("\n" + ">City<");
        for (int i = 0; i < city; i++) {
            System.out.println((i + 1) + ". " + cityName[i]);
        }

    }
}