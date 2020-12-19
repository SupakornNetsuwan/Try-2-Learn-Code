import java.util.*;

public class loopStudent {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        student std = new student();
        System.out.print("Enter Student Number : ");
        int numStudent = reader.nextInt();
        
        for (int i = 0; i < numStudent; i++) {
            Scanner readera = new Scanner(System.in);
            System.out.print("Enter Name : ");
            String n = readera.nextLine();
            std.setName(n);
            for (int j = 1; j <= 3; j++) {
                System.out.print("Enter Score : ");
                int Sc = readera.nextInt();
                std.setScore(j, Sc);
            }
            System.out.println();
            System.out.println(std.toString());
            System.out.println(std.getName() + "High Score : " + std.getHighScore());
            System.out.println();
        }
    }
}