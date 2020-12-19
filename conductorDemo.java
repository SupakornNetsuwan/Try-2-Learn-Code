public class conductorDemo {
    public String Color;
    private int Speed;

    public int SpeedUp(){
        Speed += 5;
        return Speed;
    }
    public int SpeedDown(){
        Speed -= 5;
        return Speed;
    }
    conductorDemo(){
        Color = "Black";
        Speed = 0;
        System.out.println("Strat Color = " + Color);
        System.out.println("Strat Speed = " + Speed);
    }
}