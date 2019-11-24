class BasicsDemo {
    // 1. Naming rules for classes/methods/variables
            // a) First character: letter, underscore, $
            //    Remaining: letter, underscore, $, numbers
            // b) No reserved keywords (see resources section)
    int id1 = 0;


    // 2. **Java is case-sensitive
    int id = 0;
    int Id = 0;
    int ID = 0;

    void foo() {}
    void Foo() {}

    // 3. Printing to console
    static void print() {
        System.out.println("\n\nInside print ...");
        System.out.println("Hello, world!!");
        System.out.println();
        System.out.print("Hello, world!!");
        System.out.println("Hello,");
        System.out.print(" ");
        System.out.print("world!!");
    }

    public static void main (String[] args) {
        print();

        int i = 6;
        int j = 2;
        System.out.println(i + j);
        System.out.println(i - j);
        System.out.println(i * j);
        System.out.println(i / j);
        System.out.println(i % j);
    }

    // 4. Comments or Disabling code

    // 5. Arithmetic Operations

}