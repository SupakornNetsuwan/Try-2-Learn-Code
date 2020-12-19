package testjava;

public class Work1 {

	public static void main(String[] args) {
		char A = 'A',B = 't';
		float C = (float) -5.5,D = (float) -2.5;
		int x = 256,y = 8;
		
		System.out.println(!(A!='A')&&((C%2)>D));
		System.out.println(!((B <='t')||((D - C))>0));
		System.out.println(!((A <='a')||(A!=B)&&((C+D)==3)));
		System.out.println((x^y)&x);
	}

}
