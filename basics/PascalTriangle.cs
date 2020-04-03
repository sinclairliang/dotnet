using System;
public class SolutionCLass {
    public void PascalTriangle(int row) {
        int col = 1;
        for(int i =1; i < row; i++) {
            for(int space = 1; space <= row-i; space++) {
                Console.Write(" ");
            }
            for(int j = 0; j <= i; j++) {
                if(j==0||i==0) {
                    col = 1;
                } else {
                    col = col * (i-j+1)/j;
                }
                Console.Write("{0}  ", col);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args) {
        Console.WriteLine("Hello World!");
    }
}