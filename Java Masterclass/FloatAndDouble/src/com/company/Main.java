package com.company;

public class Main {

    public static void main(String[] args) {
        // width of int = 32 (4 bytes)
        // width of float = 32 (4 bytes)
        // width of double = 64 (8 bytes)

        int myIntValue = 5;
        float myFLoatValue = 5f;
        double myDoubleValue = 5d;
        System.out.println("myIntValue = " + myIntValue);
        System.out.println("myFloatValue = " + myFLoatValue);
        System.out.println("myDoubleValue = " + myDoubleValue);

        int myIntValue1 = 5 / 3;
        float myFLoatValue1 = 5f / 3f;
        double myDoubleValue1 = 5d / 3f;
        System.out.println("myIntValue1 = " + myIntValue1);
        System.out.println("myFloatValue1 = " + myFLoatValue1);
        System.out.println("myDoubleValue1 = " + myDoubleValue1);

        // Convert a given number of pounds to kilogram
        // 1. Create a variable to store the number of pounds
        // 2. Calculate the number of kilograms fo the number above and store in variabl
        // 3. Print out the result
        //
        // NOTES: 1 pound is equal to 0.45359237 kilograms

        double myPounds = 200d;
        double totalKilos = 0.45359237d * myPounds;
        System.out.println(myPounds + " pounds equals " + totalKilos + " kilos");


    }
}
