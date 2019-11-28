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

    static void primitives() {
        System.out.println("\n\nInside primitives ...");
        int intHex = 0x0041;
        System.out.println("intHex: " + intHex);
        int intBinary = 0b01000001;
        System.out.println("intBinary: " + intBinary);
        int intUnderscore = 1_23_456;
        System.out.println("intUnderscore: " + intUnderscore);
        int intChar = 'A'; // holds decimal equivalent, which is 65
        System.out.println("intChar: " + intChar);

        char charA = 'A';
        System.out.println("charA: "+ charA);
        char charInt =65;
        System.out.println("charInt: "+ charInt);
        char charUnicode1 = '\u0041'; // 4 * (16 power 1) + 1 * (16 power 0)
        System.out.println("charUnicode1: "+ charUnicode1);
        char charHex = 0x41;     // 4 * (16 power 1) + 1 * (16 power 0)
        System.out.println("charHex: "+ charHex);
        char charBinary = 0b01000001; // binary corresponding to decimal 65
        System.out.println("charBinary: "+ charBinary);
    }

    static void typeCasting() {
        System.out.println("\nInside typeCasting ...");
        // Explicit casting
        long y = 42;
        int x = (int) y;
        // int x = y (int) y;

        // Information loss due to out-of-range assignment
        byte narrowdByte = (byte)123456;
        System.out.println("narrowdByte: " + narrowdByte);

        // Truncation
        int iTruncated = (int)0.99;
        System.out.println("iTruncated: " + iTruncated);

        // Implicit cast (int to long)
        y = x;

        // Implicit cast (char to int)
        char cChar = 'A';
        int iInt = cChar;
        System.out.println("iInt: " + iInt);

        // byte to char using an explicit cast
        byte bByte = 65;
        cChar = (char)bByte; // special conversion (widening from byte --> int followed by) narrowing from int --> char
        System.out.println("cChar: " + cChar);
    }

    public static void main (String[] args) {
        
        

        int i = 6;
        int j = 2;
        System.out.println("\n\nInside arithmatics ...");
        System.out.println(i + j);
        System.out.println(i - j);
        System.out.println(i * j);
        System.out.println(i / j);
        System.out.println(i % j);
        
        

        boolean isInsured = true;
        
        double coverageByInsurance = 0.8;
        double billAmount = 1000.0;
        
        double amountPaidByInsurance = 0.0;
        double amountPaidByPatient = billAmount;

        if (isInsured){
            amountPaidByInsurance = billAmount * coverageByInsurance;
            amountPaidByPatient = billAmount - amountPaidByInsurance;
        }

        System.out.println(amountPaidByInsurance);
        System.out.println(amountPaidByPatient);

        print();
        primitives();
        typeCasting();
    }

    // 4. Comments or Disabling code

    // 5. Arithmetic Operations

}