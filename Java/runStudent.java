public class runStudent {

    public static void main(String[] args) {
        student s1,s2,s3;
        s1 = new student();
        s2 = new student();
        s3 = new student();

        s1.setName("D");
        s1.setScore(1, 60);
        s1.setScore(2, 30);
        s1.setScore(3, 70);

        s2.setName("Nice");
        s2.setScore(1, 80);
        s2.setScore(2, 50);
        s2.setScore(3, 40);
        
        s3.setName("Tong");
        s3.setScore(1, 40);
        s3.setScore(2, 50);
        s3.setScore(3, 70);

        System.out.println();
        System.out.println(s1.toString());
        System.out.println(s1.getName() + "High Score : " + s1.getHighScore());

        System.out.println();
        System.out.println(s2.toString());
        System.out.println(s2.getName() + "High Score : " + s2.getHighScore());

        System.out.println();
        System.out.println(s3.toString());
        System.out.println(s3.getName() + "High Score : " + s3.getHighScore());
    }
}