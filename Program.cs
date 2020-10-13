using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int[] row1 = new int[3];
        static int[] row2 = new int[3];
        static int[] row3 = new int[3];
        static bool endGame = false;
        static bool isFirstMove = true;
        static bool isSecondMove = true;
        static void print(int n) {
            switch (n) { 
                case 0:
                    Console.Write(" -");
                    break;
                case 1:
                    Console.Write(" X");
                    break;
                case 2:
                    Console.Write(" O");
                    break;
            }
        }
        static bool isValidNumber(string s) {
            for (int i = 0; i < s.Length; i++)
                if (s[i] > '9' || s[i] < '0')
                    return false;
            return true;
        }
        static void print(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
                print(arr[i]);
            Console.WriteLine();
        }
        static void print() {
            Console.Write(" ");
            for(int i=0;i<3;i++)
                Console.Write(" "+(i+1));
            Console.WriteLine();
            Console.Write("1");
            print(row1);
            Console.Write("2");
            print(row2);
            Console.Write("3");
            print(row3);

        }
        static int generate() {
            return new Random().Next(1, 3);
        }
        static bool checkFull(int []arr) {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 0)
                    return false;
            return true;
        }
        static void checkWin() {
            int countPlayer=0;
            int countComputer=0;
            for (int i = 0; i < 3; i++)
                if (row1[i] == 1)
                    countPlayer++;
                else if (row1[i] == 2)
                    countComputer++;
            if (countPlayer == 3) {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countPlayer = 0;
            countComputer = 0;
            for (int i = 0; i < 3; i++)
                if (row2[i] == 1)
                    countPlayer++;
                else if (row1[i] == 2)
                    countComputer++;
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countPlayer = 0;
            countComputer = 0;
            for (int i = 0; i < 3; i++)
                if (row3[i] == 1)
                    countPlayer++;
                else if (row1[i] == 2)
                    countComputer++;
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countComputer = 0;
            countPlayer = 0;
            countPlayer=((row1[0]==1)?1:0)+((row2[1]==1)?1:0)+((row3[2]==1)?1:0);
            countComputer = ((row1[0] == 2) ? 1 : 0) + ((row2[1] == 2) ? 1 : 0) + ((row3[2] == 2) ? 1 : 0);
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countComputer = 0;
            countPlayer = 0;
            countPlayer = ((row1[2] == 1) ? 1 : 0) + ((row2[1] == 1) ? 1 : 0) + ((row3[0] == 1) ? 1 : 0);
            countComputer = ((row1[2] == 2) ? 1 : 0) + ((row2[1] == 2) ? 1 : 0) + ((row3[0] == 2) ? 1 : 0);
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countPlayer = ((row1[0] == 1) ? 1 : 0) + ((row2[0] == 1) ? 1 : 0) + ((row3[0] == 1) ? 1 : 0);
            countComputer = ((row1[0] == 2) ? 1 : 0) + ((row2[0] == 2) ? 1 : 0) + ((row3[0] == 2) ? 1 : 0);
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countPlayer = ((row1[1] == 1) ? 1 : 0) + ((row2[1] == 1) ? 1 : 0) + ((row3[1] == 1) ? 1 : 0);
            countComputer = ((row1[1] == 2) ? 1 : 0) + ((row2[1] == 2) ? 1 : 0) + ((row3[1] == 2) ? 1 : 0);
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            countPlayer = ((row1[2] == 1) ? 1 : 0) + ((row2[2] == 1) ? 1 : 0) + ((row3[2] == 1) ? 1 : 0);
            countComputer = ((row1[2] == 2) ? 1 : 0) + ((row2[2] == 2) ? 1 : 0) + ((row3[2] == 2) ? 1 : 0);
            if (countPlayer == 3)
            {
                Console.WriteLine("Player Win");
                endGame = true;
                return;
            }
            if (countComputer == 3)
            {
                Console.WriteLine("Computer Win");
                endGame = true;
                return;
            }
            if (checkFull(row1) && checkFull(row2) && checkFull(row3)) {
                Console.WriteLine("Its a Draw");
                endGame = true;
            }
        }
        static bool checkIsEmptyCell(int row, int column) {
            if (column < 1)
                return false;
            switch(row){
                case 1:
                    return row1[column-1] == 0;
                case 2:
                    return row2[column-1] == 0;
                case 3:
                    return row3[column-1] == 0;
            }
            return false;
        }
        static int getEmptyColumnInRow(int []arr) {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 0)
                    return 1 + i;
            return -1;
        }
        static int getEmptyRow() { 
            return getEmptyColumnInRow(row1)!=-1?1:(getEmptyColumnInRow(row2)!=-1)?2:(getEmptyColumnInRow(row3)!=-1)?3:1;
        }
        static void computerTurnRandom() {
            bool isValid;
            int row, column;
            int countTry = 0;
            do
            {
                isValid = true;
                row = generate();
                column = generate();
                if (checkIsEmptyCell(row, column) == false)
                {
                    isValid = false;
                    countTry++;
                }
                if (countTry == 1000)
                {
                    row = getEmptyRow();
                    switch (row)
                    {
                        case 1:
                            column = getEmptyColumnInRow(row1);
                            break;
                        case 2:
                            column = getEmptyColumnInRow(row2);
                            break;
                        case 3:
                            column = getEmptyColumnInRow(row3);
                            break;
                    }
                    isValid = true;
                }


            } while (isValid == false);
            switch (row)
            {
                case 1:
                    row1[column - 1] = 2;
                    break;
                case 2:
                    row2[column - 1] = 2;
                    break;
                case 3:
                    row3[column - 1] = 2;
                    break;
            }
        }
        static int countORow(int []arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 1)
                    count++;
            return count;
        }
        static int countXRow(int []arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == 2)
                    count++;
            return count;
        }
        static int countOColumnsRow(int n) {
            return (row1[n - 1] == 1 ? 1 : 0) + (row2[n - 1] == 1 ? 1 : 0) + (row3[n - 1] == 1 ? 1 : 0);
        }
        static int countXColumnsRow(int n) { 
            return (row1[n-1]==2?1:0)+(row2[n-1]==2?1:0)+(row3[n-1]==2?1:0);
        }
        static int getEmptyRowInColumn(int n) {
            if (row1[n - 1] == 0)
                return 1;
            if (row2[n - 1] == 0)
                return 2;
            if (row3[n - 1] == 0)
                return 3;
            return -1;
        }
        static int findGoodRowPlayer() {
            int countR1, countR2, countR3;
            countR1 = countORow(row1);
            countR2 = countORow(row2);
            countR3 = countORow(row3);
            if (countR1 == 2 && getEmptyColumnInRow(row1) != -1)
                return 1;
            if (countR2 == 2 && getEmptyColumnInRow(row2) != -1)
                return 2;
            if (countR3 == 2 && getEmptyColumnInRow(row3) != -1)
                return 3;
            return -1;
        }
        static int findGoodRow() {
            int countR1, countR2, countR3;
            countR1 = countXRow(row1);
            countR2 = countXRow(row2);
            countR3 = countXRow(row3);
            if (countR1 == 2 && getEmptyColumnInRow(row1) != -1)
                return 1;
            if (countR2 == 2 && getEmptyColumnInRow(row2) != -1)
                return 2;
            if (countR3 == 2 && getEmptyColumnInRow(row3) != -1)
                return 3;
            return -1;
        }
        static int findGoodColumnPlayer() {
            int col1, col2, col3;
            col1 = countOColumnsRow(1);
            col2 = countOColumnsRow(2);
            col3 = countOColumnsRow(3);
            if (col1 == 2 && getEmptyRowInColumn(1) != -1)
                return 1;
            if (col2 == 2 && getEmptyRowInColumn(2) != -1)
                return 2;
            if (col3 == 2 && getEmptyRowInColumn(3) != -1)
                return 3;
            return -1;
        }
        static int findGoodColumn() {
            int col1, col2, col3;
            col1 = countXColumnsRow(1);
            col2 = countXColumnsRow(2);
            col3 = countXColumnsRow(3);
            if (col1 == 2 && getEmptyRowInColumn(1) != -1)
                return 1;
            if (col2 == 2 && getEmptyRowInColumn(2) != -1)
                return 2;
            if (col3 == 2 && getEmptyRowInColumn(3) != -1)
                return 3;
            return -1;
        }
        static int countXDiagonal1() { 
            return (row1[0]==1?1:0)+(row2[1]==1?1:0)+(row3[2]==1?1:0);
        }
        static int countODiagonal1()
        {
            return (row1[0] == 2 ? 1 : 0) + (row2[1] == 2 ? 1 : 0) + (row3[2] == 2 ? 1 : 0);
        }
        static int countODiagonal2()
        {
            return (row1[2] == 2 ? 1 : 0) + (row2[1] == 2 ? 1 : 0) + (row3[0] == 2 ? 1 : 0);
        }
        static int countXDiagonal2() { 
            return (row1[2]==1?1:0)+(row2[1]==1?1:0)+(row3[0]==1?1:0);
        }
        static int findEmptyDiagonal1() {
            if (row1[0] == 0)
                return 1;
            if (row2[1] == 0)
                return 2;
            if (row3[2] == 0)
                return 3;
            return -1;
        }
        static int findEmptyDiagonal2() {
            if (row1[2] == 0)
                return 1;
            if (row2[1] == 0)
                return 2;
            if (row3[0] == 0)
                return 3;
            return -1;
        }
        static void computerTurnSmart()
        {
            if (isFirstMove) {
                isFirstMove = false;
                if (row2[1] == 1)
                {
                    if (row1[0] == 0)
                        row1[0] = 2;
                    else if (row1[2] == 0)
                        row1[2] = 2;
                }
                else {
                    row2[1] = 2;
                }
                
            }else if (findGoodColumn() == -1 && findGoodRow() == -1 && findGoodRowPlayer() == -1 && findGoodColumnPlayer() == -1 && (countXDiagonal1() != 2 || findEmptyDiagonal1() == -1)
                && (countODiagonal1() != 2 || findEmptyDiagonal1() == -1) && (countXDiagonal2() != 2 || findEmptyDiagonal2() == -1) && (countODiagonal2() != 2 || findEmptyDiagonal2() == -1)&&isSecondMove==false)
            {
                computerTurnRandom();
            }
            else if (findGoodColumn() != -1 || findGoodRow() != -1)
            {
                Console.WriteLine("Smart");
                int goodRow = findGoodRow();
                int row = 0;
                int goodColumn = findGoodColumn();
                int column = 0;
                if (goodRow != -1)
                {
                    row = goodRow;
                    switch (row)
                    {
                        case 1:
                            column = getEmptyColumnInRow(row1);
                            break;
                        case 2:
                            column = getEmptyColumnInRow(row2);
                            break;
                        case 3:
                            column = getEmptyColumnInRow(row3);
                            break;
                    }
                    
                }
                else
                {
                    column = goodColumn;
                    row = getEmptyRowInColumn(column);
                }
                switch (row)
                {
                    case 1:
                        row1[column - 1] = 2;
                        break;
                    case 2:
                        row2[column - 1] = 2;
                        break;
                    case 3:
                        row3[column - 1] = 2;
                        break;
                }
                isSecondMove = false;
            }
            else if (countODiagonal1() == 2 && findEmptyDiagonal1() != -1)
            {
                Console.WriteLine("Smart");
                int row, column;
                row = column = findEmptyDiagonal1();
                switch (row)
                {
                    case 1:
                        row1[column - 1] = 2;
                        break;
                    case 2:
                        row2[column - 1] = 2;
                        break;
                    case 3:
                        row3[column - 1] = 2;
                        break;
                }
                isSecondMove = false;
            }
            else if (countODiagonal2() == 2 && findEmptyDiagonal2() != -1)
            {
                Console.WriteLine("Smart");
                int row;
                row = findEmptyDiagonal2();
                switch (row)
                {
                    case 1:
                        row1[2] = 2;
                        break;
                    case 2:
                        row2[1] = 2;
                        break;
                    case 3:
                        row3[0] = 2;
                        break;
                }
                isSecondMove = false;
            }
            else if (findGoodRowPlayer() != -1 || findGoodColumnPlayer() != -1)
            {
                Console.WriteLine("Smart");
                int goodRow = findGoodRowPlayer();
                int goodColumn = findGoodColumnPlayer();
                int row = 0;
                int column = 0;
                if (goodRow != -1)
                {
                    row = goodRow;
                    switch (row)
                    {
                        case 1:
                            column = getEmptyColumnInRow(row1);
                            break;
                        case 2:
                            column = getEmptyColumnInRow(row2);
                            break;
                        case 3:
                            column = getEmptyColumnInRow(row3);
                            break;
                    }
                }
                else
                {
                    column = goodColumn;
                    row = getEmptyRowInColumn(column);
                }
                switch (row)
                {
                    case 1:
                        row1[column - 1] = 2;
                        break;
                    case 2:
                        row2[column - 1] = 2;
                        break;
                    case 3:
                        row3[column - 1] = 2;
                        break;
                }
                isSecondMove = false;
            }
            else if (countXDiagonal1() == 2 && findEmptyDiagonal1() != -1)
            {
                Console.WriteLine("Smart");
                int row, column;
                row = column = findEmptyDiagonal1();
                switch (row)
                {
                    case 1:
                        row1[column - 1] = 2;
                        break;
                    case 2:
                        row2[column - 1] = 2;
                        break;
                    case 3:
                        row3[column - 1] = 2;
                        break;
                }
                isSecondMove = false;
            }
            else if (countXDiagonal2() == 2 && findEmptyDiagonal2() != -1)
            {
                Console.WriteLine("Smart");
                int row;
                row = findEmptyDiagonal2();
                switch (row)
                {
                    case 1:
                        row1[2] = 2;
                        break;
                    case 2:
                        row2[1] = 2;
                        break;
                    case 3:
                        row3[0] = 2;
                        break;
                }
                isSecondMove = false;
            }
            else if (isSecondMove == true)
            {
                if (row2[1] == 2) {
                    if (row1[1] == 0)
                        row1[1] = 2;
                    else if (row2[0] == 0)
                        row2[0] = 2;
                    else if (row2[2] == 0)
                        row2[2] = 2;
                    else if (row3[1] == 0)
                        row3[1] = 2;
                }else if (row1[0] == 0)
                    row1[0] = 2;
                else if (row1[2] == 0)
                    row1[2] = 2;
                else if (row3[0] == 0)
                    row3[0] = 2;
                else
                    row3[2] = 2;
                isSecondMove = false;
            }
        }
        static void game() {
            print();
            while (endGame == false) {
                bool isValid = true;
                int row=0, column=0;
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter a row");
                    string input = Console.ReadLine();
                    if (isValidNumber(input) == false || input.Length == 0 || int.Parse(input) > 3 || int.Parse(input)<1)
                    {
                        Console.WriteLine("Invalid input please enter again");
                        isValid = false;
                        continue;
                    }
                    row = int.Parse(input);
                    Console.WriteLine("Enter a column");
                    input = Console.ReadLine();
                    if (isValidNumber(input) == false || input.Length == 0 || int.Parse(input) > 3 || int.Parse(input) < 1 || checkIsEmptyCell(row, int.Parse(input))==false )
                    {
                        Console.WriteLine("Invalid input or the cell is full please enter again");
                        isValid = false;
                        continue;
                    }
                    column = int.Parse(input);
                } while(isValid == false);
                switch (row) { 
                    case 1:
                        row1[column-1] = 1;
                        break;
                    case 2:
                        row2[column-1] = 1;
                        break;
                    case 3:
                        row3[column-1] = 1;
                        break;
                } 
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                print();
                checkWin();
                if (endGame)
                    break;

                computerTurnSmart();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                print();
                checkWin();
            }
        }
        static void Main(string[] args)
        {
            game();
            
            Console.ReadLine();
        }
    }
}
