import java.util.Scanner;
public class salary {

	public static void main(String[] args) {
		Scanner t = new Scanner(System.in);
		String Name;
		double hour,rate,result;
		
		System.out.print("Name? : ");
		Name = t.nextLine();
		System.out.print("Hour per Week : ");
		hour = t.nextInt();
		System.out.print("Rate per Hour : ");
		rate = t.nextInt();
		result = hour * rate;
		System.out.println("Name : " + Name + "\n" + "Your gross pay is " + result + " Bath" );
	}

}
