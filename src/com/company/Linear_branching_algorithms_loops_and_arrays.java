package com.company;

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Linear_branching_algorithms_loops_and_arrays {
    Scanner in = new Scanner(System.in);

    public static void main(String[] args) throws Exception {
        String selectionChoiceTrue = ("y");
        String selectionChoice;
        Scanner in = new Scanner(System.in);
        Linear_branching_algorithms_loops_and_arrays obj = new Linear_branching_algorithms_loops_and_arrays();
        System.out.println("Application for solving problems 6 options");
        System.out.println("Choose whatever task you want to solve: linearAlgorithms (1), forkingAlgorithms (2), forLoop (3), whileLoop (4), doWhileLoop (5), arrays (6), doubleArrays (7)");


        do {
            System.out.print("Enter the task number: ");
            int selection = in.nextInt();
            switch (selection) {
                case 1 -> {
                    System.out.println("\nSelected solution task 'linearAlgorithms'");
                    obj.linearAlgorithms();
                }
                case 2 -> {
                    System.out.println("\nSelected solution task 'forkingAlgorithms'");
                    obj.forkingAlgorithms();
                }
                case 3 -> {
                    System.out.println("\nSelected solution task 'forLoop'");
                    obj.forLoop();
                }
                case 4 -> {
                    System.out.println("\nSelected solution task 'whileLoop'");
                    obj.whileLoop();
                }
                case 5 -> {
                    System.out.println("\nSelected solution task 'doWhileLoop'");
                    obj.doWhileLoop();
                }
                case 6 -> {
                    System.out.println("\nSelected solution task 'arrays'");
                    obj.arrays();
                }
                case 7 -> {
                    System.out.println("\nSelected solution task 'doubleArrays'");
                    obj.doubleArrays();
                }
                default -> System.out.println("Решение выбранной вами задачи отсутствует");
            }
            System.out.println("\n\nChoose another task? (y/n)");
            System.out.print("Type choice: ");
            selectionChoice = (in.next());
        }
        while (selectionChoice.equals(selectionChoiceTrue));
    }


    public void linearAlgorithms() throws Exception {
        double a, b, x, result;
        try (var fr = new FileReader("input/linearAlgorithmsInput.txt")) {
            Scanner scan = new Scanner(fr);
            a = scan.nextDouble();
            b = scan.nextDouble();
        }
        System.out.print("Input x: ");
        x = in.nextDouble();
        result = Math.pow((a * x), 1 / 5f) + Math.pow((b * x), 1 / 3f);
        System.out.printf("result: %1$.3f", result);
        try (var fw = new FileWriter("output/linearAlgorithmsOutput.txt")) {
            fw.write("result: " + result);
        }
    }

    public void forkingAlgorithms() {
        double a, b, c, d;
        System.out.print("Input variables: ");
        a = in.nextDouble();
        b = in.nextDouble();
        c = in.nextDouble();
        d = in.nextDouble();
        if (a > 3 && a < 15) System.out.println("variable A belongs to the segment");
        else System.out.println("variable A does not belongs to the segment");
        if (b > 3 && b < 15) System.out.println("variable B belongs to the segment");
        else System.out.println("variable B does not belongs to the segment");
        if (c > 3 && c < 15) System.out.println("variable C belongs to the segment");
        else System.out.println("variable C does not belongs to the segment");
        if (d > 3 && d < 15) System.out.print("variable D belongs to the segment");
        else System.out.print("variable D does not belongs to the segment");
    }

    public void forLoop() throws IOException {
        String selectionTrue = ("n");
        try (var fw = new FileWriter("output/forLoopOutput.txt")) {
            for (; ; ) {
                System.out.print("Enter number: ");
                double var = in.nextDouble();
                if (var > 0 && var % 3 == 0) {
                    System.out.printf("Number %1$s is positive and multiple of 3 \n", var);
                    fw.write("Number " + var + " is positive and multiple of 3 \n");
                }
                System.out.println("Want to check another number? (y / n)");
                System.out.print("Type choice: ");
                String selection = in.next();
                if (selection.equals(selectionTrue))
                    break;
            }
        }
    }

    public void whileLoop() throws IOException {
        double n, result = 0, k = 1;
        System.out.print("Enter N: ");
        n = in.nextDouble();
        while (result < n) {
            result = Math.pow(3, k);
            k++;
        }
        System.out.printf("The highest number is: %1$s", result / 3);
        try (var fw = new FileWriter("output/whileLoopOutput.txt")) {
            fw.write("The highest number is:" + result / 3);
        }
    }

    public void doWhileLoop() throws IOException {
        double count = 5, result;
        try (var fw = new FileWriter("output/doWhileLoopOutput.txt")) {
            do {
                result = Math.sin(count) + 5 * Math.cos(count - 2);
                count -= 1.2;
                if (result > 0) {
                    System.out.printf("Result: %1$.3f \n", result);
                    fw.write("Result: " + result + "\n");
                }
            } while (count > -10);
        }
    }

    public void arrays() throws IOException {
        double sum = 0;
        System.out.print("Enter array length: ");
        int size = in.nextInt();
        int[] array = new int[size];
        System.out.print("Insert array elements: ");
        for (int i = 1; i < size; i++) {
            array[i] = in.nextInt();
            if (i % 2 != 0)
                sum += array[i];
        }
        try (var fw = new FileWriter("output/arrays.txt")) {
            System.out.print("Inserted array elements:");
            fw.write("Inserted array elements:");
            for (int i = 0; i < size; i++) {
                System.out.print(" " + array[i]);
                fw.write(" " + array[i]);
            }
            System.out.printf("\nSum of values: %1$.3f", sum);
            fw.write("\nSum of values: " + sum);
        }
    }

    private void doubleArrays() throws IOException {
        try (var fw = new FileWriter("output/doubleArrays.txt")) {
            System.out.println("The conditions of the problem are not exact, in this regard, I bring out a goose");
            System.out.print("""
                    ░░░░░▄▀▀▀▄░░░░░░░░░░░░░░░░░░
                    ▄███▀░◐░░░▌░░░░░░░░░░░░░░░░░
                    ░░░▌░░░░░▐░░░░░░░░░░░░░░░░░░
                    ░░░░▐░░░░░▐░░░░░░░░░░░░░░░░░
                    ░░░░▌░░░░░▐▄▄░░░░░░░░░░░░░░░
                    ░░░░▌░░░░▄▀▒▒▀▀▀▀▄░░░░░░░░░░
                    ░░░▐░░░░▐▒▒▒▒▒▒▒▒▀▀▄░░░░░░░░
                    ░░░▐░░░░▐▄▒▒▒▒▒▒▒▒▒▒▀▄░░░░░░
                    ░░░░▀▄░░░░▀▄▒▒▒▒▒▒▒▒▒▒▀▄░░░░
                    ░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄░░
                    ░░░░░░░░░░░▌▌▌▌░░░░░░░░░░░░░
                    ░░░░░░░░░░░▌▌░▌▌░░░░░░░░░░░░
                    ░░░░░░░░░▄▄▌▌▄▌▌░░░░░░░░░░░░""".indent(8));
            fw.write("The conditions of the problem are not exact, in this regard, I bring out a goose\n");
            fw.write("""
                    ░░░░░▄▀▀▀▄░░░░░░░░░░░░░░░░░░
                    ▄███▀░◐░░░▌░░░░░░░░░░░░░░░░░
                    ░░░▌░░░░░▐░░░░░░░░░░░░░░░░░░
                    ░░░░▐░░░░░▐░░░░░░░░░░░░░░░░░
                    ░░░░▌░░░░░▐▄▄░░░░░░░░░░░░░░░
                    ░░░░▌░░░░▄▀▒▒▀▀▀▀▄░░░░░░░░░░
                    ░░░▐░░░░▐▒▒▒▒▒▒▒▒▀▀▄░░░░░░░░
                    ░░░▐░░░░▐▄▒▒▒▒▒▒▒▒▒▒▀▄░░░░░░
                    ░░░░▀▄░░░░▀▄▒▒▒▒▒▒▒▒▒▒▀▄░░░░
                    ░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄░░
                    ░░░░░░░░░░░▌▌▌▌░░░░░░░░░░░░░
                    ░░░░░░░░░░░▌▌░▌▌░░░░░░░░░░░░
                    ░░░░░░░░░▄▄▌▌▄▌▌░░░░░░░░░░░░""".indent(8));
        }
    }
}
