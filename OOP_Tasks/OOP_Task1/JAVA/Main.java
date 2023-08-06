package org.example;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        char o;
        int x, y;

        while (true)
        {
            System.out.print("Enter first number: ");
            x = scanner.nextInt();

            System.out.print("Enter operation: ");
            o = scanner.next().charAt(0);

            System.out.print("Enter second number: ");
            y = scanner.nextInt();

            switch (o)
            {
                case '+':
                    System.out.println("sum is " + myMath.Sum(x, y));
                    break;
                case '-':
                    System.out.println("sub is " + myMath.Sub(x, y));
                    break;
                case '*':
                    System.out.println("mul is " + myMath.Mul(x, y));
                    break;
                case '/':
                    System.out.println("div is " + myMath.Div(x, y));
                    break;
                case '%':
                    System.out.println("rem is " + myMath.Rem(x, y));
                    break;
                default:
                    System.out.println("Inavalid Operation");
                    break;
            }
            System.out.print("Another Operation? ");
            o = scanner.next().charAt(0);

            if (o != 'T')
                break;
        }
    }
}