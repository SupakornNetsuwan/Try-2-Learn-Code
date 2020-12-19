import java.util.Scanner;;

class setScore {
    public float scoreCalc() {
        Scanner reader = new Scanner(System.in);
        float m, e, t;
        System.out.print("Mid Term : ");
        m = reader.nextFloat();
        System.out.print("Final Term : ");
        e = reader.nextFloat();
        System.out.print("Test Score : ");
        t = reader.nextFloat();
        float Score = m + e + t;
        return Score;
    }
}