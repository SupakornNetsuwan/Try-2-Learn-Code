class grade {
    public String gradeCalc(float score) {
        String T = "";
        if (score < 0 || score > 100) {
            T = "Error";
        } else if (score >= 80) {
            T = "4";
        } else if (score >= 70) {
            T = "3";
        } else if (score >= 60) {
            T = "2";
        } else if (score >= 50) {
            T = "1";
        } else if (score < 50) {
            T = "0";
        }
        return T;
    }

}