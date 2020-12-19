import java.util.Scanner;

public class Work2862019 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		float gpax;

		System.out.print("เกรดเฉลี่ยของคุณ : ");
		gpax = input.nextFloat();

		if (gpax <= 4 && gpax >= 2) {
			if (gpax >= 2.0) {
				if (gpax >= 3.90) {
					System.out.println("นักเรียนสามารถเข้าคณะแพทย์ได้");
				} else if (gpax >= 3.50) {
					System.out.println("นักเรียนสามารถเข้าคณะทันตแพทย์ได้");
				} else if (gpax >= 3) {
					System.out.println("นักเรียนสามารถเข้าคณะวิศวกรรมได้");
				} else if (gpax >= 2.75) {
					System.out.println("นักเรียนสามารถเข้าคณะไอทีได้");
				} else {
					System.out.println("นักเรียนสามารถเข้าคณะอื่นได้");
				}
			}
		}else{
			System.out.println("เกิดข้อผิดพลาด กรุณาตรวจสอบ เกรดเฉลี่ย ของคุณ");
		}

	}

}
