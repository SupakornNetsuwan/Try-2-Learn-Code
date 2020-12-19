import java.util.Scanner;

public class array2d {

    public static void main(String[] args) {
    Scanner key = new Scanner(System.in);
    Scanner nonkey = new Scanner(System.in);
    System.out.print("Row? : ");
    int w = key.nextInt();
    System.out.print("Col? : ");
    int h = key.nextInt();
    String sq[][] = new String[w][h];
    String store = "";
    for (int i = 0; i < w; i++) {
        for (int j = 0; j < h; j++) {
            System.out.print("Enter city name : ");
        sq[0][j] = nonkey.nextLine();
        store = store + sq[0][j] + "\t";
    }
    store = store + "\n";
    }
    
    System.out.println(">City<"); 
    System.out.println(store);
    }
 
}