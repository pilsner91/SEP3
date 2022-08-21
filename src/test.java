public class test {

    private static String type = "String Blocks";
    private static String variables = "variables in the format;";

    public static void main(String[] args) {
        System.out.println("hallo world");

        System.out.println("""
                Remember to use %s
                and use all the proper %s
                """.formatted(type, variables));
    }
}
