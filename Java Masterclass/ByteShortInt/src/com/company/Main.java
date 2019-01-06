package com.company;

public class Main {

    public static void main(String[] args) {

        // Int has a width of 32
        int myValue = 10000;
        int myMinValue = -2_147_483_648; //met underscores kun je getallen wat meer leesbaar maken.
        int myMaxValue = 2147483647;

        int myTotal = (myMinValue / 2);
        System.out.println("myTotal = " + myTotal);

        // Byte has a width of 8
        byte myByteValue = 10;
        byte myByteMinValue = -128;
        byte myByteMaxValue = 127;

        byte myNewByteValue = (byte) (myByteValue/2);
        System.out.println("myNewByteValue = " + myNewByteValue);

        // Short has a width of 16
        short myShortValue = 30000;
        short myShortMinValue = -32768;
        short myShortMaxValue = 32767;

        short myNewShortValue = (short) (myShortValue / 2);
        System.out.println("myNewShortValue = " + myNewShortValue);

        // Long has a width of 64
        long myLongValue = 100L;
        long myLongMinValue = -9_223_372_036_854_775_808L;
        long myLongMaxValue = 9223372036854775807L;

        // 1. Create a byte variable and set it to any valid byte number
        // 2. Create a short variable and set it to any valid short number
        // 3. Create a int variable and set it to any valid int number
        // 4. Create a variable of type long, and make it equal to
        //    50000 + 10 times the sum of the byte, plus the short plus the int

        byte newByte = 20;
        short newShort = 30;
        int newInt = 40;
        long newLong = 50000L + (10L * (newByte + newShort + newInt));
        short shortTotal = (short) (1000 + 10 * (newByte + newShort + newInt));
        System.out.println("newLong = " + newLong);
        System.out.println("shortTotal = " + shortTotal);
    }
}
