package com.company;

public class Main {

    public static void main(String[] args) {
        boolean gameOver = true;
        int score = 400;
        int levelCompleted = 5;
        int bonus = 100;

//        if (score < 5000 && score > 1000) {
//            System.out.println("Your score was less than 5000 but greater than 1000");
//        } else if (score < 1000){
//            System.out.println("The score was less than 1000");
//        } else {
//            System.out.println("Got here");
//        }

        if (gameOver) {
            int finalScore = score + (levelCompleted * bonus);
            System.out.println("Your final score was " + finalScore);
        }

        // print out a second score on the screen with the following
        // score set to 10000
        // LevelCompleted set to 8
        // bonus set to 200
        // But make sure first printout above still displays as well

        if (gameOver){
            score = 10000;
            levelCompleted = 8;
            bonus = 200;
            int finalScore = score + (levelCompleted * bonus);
            System.out.println("Your final score was " + finalScore);
        }

    }
}
