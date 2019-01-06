package com.company;

public class Main {

    public static void main(String[] args) {

        // Int has a width of 32
        int myValue = 10000;
        int myMinValue = -2_147_483_648; //met underscores kun je getallen wat meer leesbaar maken.
        int myMaxValue = 2147483647;

        // Byte has a width of 8
        byte myByteValue = 10;
        byte myByteMinValue = -128;
        byte myByteMaxValue = 127;

        // Short has a width of 16
        short myShortValue = 30000;
        short myShortMinValue = -32768;
        short myShortMaxValue = 32767;

        // Long has a width of 64
        long myLongValue = 100L;
        long myLongMinValue = -9_223_372_036_854_775_808L;
        long myLongMaxValue = 9223372036854775807L;


    }
}
