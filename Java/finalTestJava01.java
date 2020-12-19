import java.util.Scanner;

public class finalTestJava01{

        float Result;
        finalTestJava01(char Mode) {
            Scanner reader = new Scanner(System.in);
            if (Mode == 'D' || Mode == 'd') {
                System.out.println("Distance Calculator");
                System.out.print("Enter Speed :");
                float speed = reader.nextFloat();
                System.out.print("Enter Time : ");
                float time = reader.nextFloat();
                Result = setDestance(speed, time);
                System.out.print("Result = " + Result + " km");
            } else if (Mode == 'S' || Mode == 's') {
                System.out.println("Speed Calculator");
                System.out.print("Enter Distance : ");
                float distance = reader.nextFloat();
                System.out.print("Enter Time : ");
                float time = reader.nextFloat();
                Result = setSpeed(distance, time);
                System.out.print("Result = " + Result + "  km/h");
            } else if (Mode == 'T' || Mode == 't') {
                System.out.println("Time Calculator");
                System.out.print("Enter Distance : ");
                float distance = reader.nextFloat();
                System.out.print("Enter Speed : ");
                float Speed = reader.nextFloat();
                Result = setTime(distance, Speed);
                System.out.print("Result = " + Result + "  Hour");
            } else {
                System.out.print("Mode not found, Try again.");
            }
        }

    public static float setDestance(float speed, float time) {
        float distance = speed * time;
        return distance;
    }

    public static float setSpeed(float distance, float time) {
        float speed = distance / time;
        return speed;
    }

    public static float setTime(float distance, float speed) {
        float time = distance / speed;
        return time;
    }
}