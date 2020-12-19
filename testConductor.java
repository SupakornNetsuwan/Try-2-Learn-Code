public class testConductor {
    public static void main(String[] args) {
        conductorDemo car = new conductorDemo();
        car.Color = "Red";
        System.out.println("Current Color : " + car.Color);
        int cSpeed = car.SpeedUp();
        System.out.println(cSpeed);
    }
}