import java.util.Scanner;

public class disCal {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        System.out.print("Speed/KM : ");
        float A = reader.nextFloat();
        System.out.print("Time/Hour : ");
        float B = reader.nextFloat();
        Double distance = disCalu(A, B);
        System.out.println("Distance = " + distance + " KM");
        Double speed = spCal(distance, B);
        System.out.print("Speed = " + speed + " KM/Hour");
    }

    static double disCalu(float Speed, float Time) {
        double dis = Speed * Time;
        return dis;
    }

    static double spCal(Double Distance,float Time){
        double sp = Distance/Time;
        return sp;
    }
}