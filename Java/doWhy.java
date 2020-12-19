import java.util.Scanner;

public class doWhy {

	public static void main(String[] args) {
		int num;
		String name = "", arrrr = "",text = "";
		Scanner key = new Scanner(System.in);
		System.out.print("Enter Number : ");
		num = key.nextInt();
		for (int i = 0; i <= num; i++) {
			if (i == 0){
					text = "";
				}else{
					text = "[" + i + "/" + num + "]" + "Enter Name : ";
				}
				System.out.print(text);
				name = key.nextLine();
			if (i > 0) {
				arrrr = arrrr + "\r" + i + ". " + name;
			}
		}
		System.out.println(" LIST " + arrrr);
	}

}
