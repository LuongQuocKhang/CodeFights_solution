﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // test
            #region 2 - Edge of the Ocean
            #region ArrayConsecutive
            //int[] statues = new int[] { 0,3 };
            //Console.WriteLine(makeArrayConsecutive2(statues));
            #endregion

            #region almostIncreasingSequence
            //int[] sequence = new int[] { 1, 3, 2 };
            //Console.WriteLine(almostIncreasingSequence(sequence));
            #endregion

            #region matrixElementsSum
            //int[][] matrix = {new int[] { 1, 1, 1, 0 },
            //                  new int[] { 0, 5, 0, 1},
            //                  new int[] { 2, 1, 3, 10 } };
            //Console.WriteLine(matrixElementsSum(matrix));
            #endregion
            #endregion

            #region 3 - Smooth Sailing
            #region allLongestStrings
            //string[] inputArray = { "aba", "aa", "ad", "vcd", "aba" };
            //List<string> list = allLongestStrings(inputArray).ToList<string>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            #region commonCharacterCount
            //string s1 = "aabcc";
            //string s2 = "adcaa";
            //Console.WriteLine(commonCharacterCount(s1,s2));
            #endregion

            #region isLucky
            //int n = 1230;
            //Console.WriteLine(isLucky(n));
            #endregion

            #region sortByHeight
            //int[] a = { 4, 2, 9, 11, 2, 16 };
            //int[] result = sortByHeight(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}
            #endregion

            #region reverseParentheses
            //string s = "a(bcdefghijkl(mno)p)q";
            //Console.WriteLine(reverseParentheses(s));
            #endregion
            #endregion

            #region 4 - Exploring the Waters
            #region alternatingSums
            //int[] array = { 80 };
            //int[] result = AlternatingSums(array);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}
            #endregion

            #region addBorder
            //string[] picture = { "a"};
            //string[] result = AddBorder(picture);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            #endregion

            #region areSimilar
            //int[] a = { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 };
            //int[] b = { 832, 998, 148, 570, 533, 561, 455, 147, 894, 279 };
            //Console.WriteLine(AreSimilar(a,b));
            #endregion

            #region arrayChange
            //int[] array = { -1000, 0, -2, 0 };
            //Console.WriteLine(ArrayChange(array));
            #endregion

            #region palindromeRearranging
            //string result = "aaabbcc";
            //Console.WriteLine(result);
            //Console.WriteLine(PalindromeRearranging(result));
            #endregion
            #endregion

            #region 5 - island of knowlegde
            #region IsIPv4Address
            //string result = "1";
            //Console.WriteLine(isIPv4Address(result));
            #endregion

            #region AvoidObstacles 
            //int[] inputarray = { 19, 32, 11, 23 };
            //Console.WriteLine(AvoidObstacles(inputarray));
            #endregion

            #region BoxBlur
            //int[][] image = {new int[] {36,0,18,9 },
            //                 new int[] {27,54,9,0},
            //                  new int[] { 81, 63, 72, 45 } };
            //int[][] result = BoxBlur(image);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    for (int j = 0; j < result[i].Length; j++)
            //    {
            //        Console.Write(result[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Minesweeper
            //bool[][] matrix = { new bool[] {true,false,false,true},
            //                    new bool[] {false,false,true,false},
            //                    new bool[] { true, true, false, true } };
            //int[][] result = Minesweeper(matrix);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    for (int j = 0; j < result[i].Length; j++)
            //    {
            //        Console.Write(result[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion

            #region 6 - Rains of Reason
            #region ArrayReplace
            //int[] inputarray = { 1, 2, 3, 4, 5 };
            //int[] result = ArrayReplace(inputarray, 3, 0);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}
            #endregion

            #region EvenDigitsOnly
            //int n = 1;
            //Console.WriteLine(EvenDigitsOnly(n));
            #endregion

            #region VariableName
            //string result = "2var_1__Int";
            //Console.WriteLine(VariableName(result));
            #endregion

            #region AlphabeticShift
            //string inputstring = "codefights";
            //Console.WriteLine(alphabeticShift(inputstring));
            #endregion

            #region ChessBoardCellColor
            //string cell1 = "B3";
            //string cell2 = "H8";
            //Console.WriteLine(ChessBoardCellColor(cell1,cell2));
            #endregion
            #endregion

            #region 7 - Through the Fog
            #region CircleOfNumbers
            //Console.WriteLine(CircleOfNumbers(4,2));
            #endregion

            #region DepositProfit
            //Console.WriteLine(DepositProfit(100,20,170));
            #endregion

            #region AbsoluteValuesSumMinimization
            //int[] a = { 2, 4, 7 };
            //Console.WriteLine(AbsoluteValuesSumMinimization(a));
            #endregion

            #region StringsRearrangement
            Console.WriteLine(StringsRearrangement(new string[] { "abc","abx","axx","abc" }));
            #endregion
            #endregion
            Console.ReadLine();
        }

        #region 1 - The Journey Begins
        public static int add(int param1, int param2)
        {
            return param1 + param2;
        }
        int centuryFromYear(int year)
        {
            int century = year / 100;
            if (year % 100 > 0)
            {
                century++;
            }
            return century;
        }
        bool checkPalindrome(string inputString)
        {
            StringBuilder palindrome = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                palindrome.Append(inputString[i]);
            }
            if (palindrome.ToString() == inputString)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 2 - Edge of the Ocean
        public static int adjacentElementsProduct(int[] inputArray)
        {
            int max = -int.MaxValue;
            int length = inputArray.Length;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 < length)
                {
                    if (inputArray[i] * inputArray[i + 1] > max)
                    {
                        max = inputArray[i] * inputArray[i + 1];
                    }
                }
            }
            return max;
        }
        public static int shapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }
        public static int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            int num = 0;
            int length = statues.Length;
            for (int i = 0; i < length; i++)
            {
                if (i - 1 >= 0)
                {
                    num += statues[i] - statues[i - 1] - 1;
                }
            }
            return num;
        }

        //public static bool AlmostIncreasingSequenceVersion1(int[] sequence)
        //{
        //    int length = sequence.Length;
        //    for (int i = 0; i < length; i++)
        //    {
        //        List<int> Temp = sequence.ToList<int>();
        //        Temp.RemoveAt(i);
        //        if (check(Temp) == true)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public static bool check(List<int> Temp)
        //{
        //    for (int i = 0; i < Temp.Count; i++)
        //    {
        //        if (i - 1 >= 0)
        //        {
        //            if (Temp[i] <= Temp[i - 1])
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
        public static bool almostIncreasingSequence(int[] sequence)
        {
            int r = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    r++;
                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                    r++;
            }
            return r <= 2;
        }
        public static int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (list.Contains(j) == false)
                    {
                        if (matrix[i][j] != 0)
                        {
                            sum += matrix[i][j];
                        }
                        else
                        {
                            list.Add(j);
                        }
                    }
                }
            }
            return sum;
        }
        #endregion

        #region 3 - Smooth Sailing
        public static string[] allLongestStrings(string[] inputArray)
        {
            List<string> temp = inputArray.ToList<string>();
            int max = temp[0].Length;
            for (int i = 0; i < temp.Count; i++)
            {
                int length = temp[i].Length;
                if (length > max)
                {
                    max = length;
                }
            }
            List<string> list = new List<string>();
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Length == max)
                {
                    list.Add(temp[i]);
                }
            }
            return list.ToArray();
        }
        public static int commonCharacterCount(string s1, string s2)
        {
            int dem = 0;
            List<int> vitri = new List<int>();
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i].Equals(s2[j]) && vitri.Contains(j) == false)
                    {
                        dem++;
                        vitri.Add(j);
                        break;
                    }
                }
            }
            return dem;
        }
        public static bool isLucky(int n)
        {
            int length = n.ToString().Length;
            int right = 0;
            int left = 0;
            for (int i = 0; i < length / 2; i++)
            {
                right += Int32.Parse(n.ToString()[i].ToString());
            }
            for (int i = length - 1; i >= length / 2; i--)
            {
                left += Int32.Parse(n.ToString()[i].ToString());
            }
            if (right == left)
            {
                return true;
            }
            return false;
        }
        public static int[] sortByHeight(int[] a)
        {
            int[] result = new int[a.Length];
            a.CopyTo(result, 0);
            int length = a.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (result[j] != -1 && result[i] != -1 && result[j] < result[i])
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        public static string reverseParentheses(string s)
        {
            // kiểm tra chuỗi có chứa "{" và "}" hay không
            bool end = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == ')')
                {
                    end = false;
                    break;
                }
            }
            if (end) return s; // nếu ko chứa thì trả về chuỗi ban đầu
            string result = "";
            int temp = 0; // kiểm tra dấu ( và ) tương ứng;
            int vt1 = -1, vt2 = -1; // vt1 là vị trí dấu ( , vt2 là vị trí dấu ) tương ứng
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (temp == 0)
                    {
                        vt1 = i + 1;
                    }
                    temp++;
                }
                else if (s[i] == ')')
                {
                    temp--;
                    if (temp == 0)
                    {
                        vt2 = i - 1;
                    }
                    if (temp == 0)
                    {
                        for (int j = vt2; j >= vt1; j--)
                        {
                            if (s[j] == '(')
                            {
                                result += ")";
                            }
                            else if (s[j] == ')')
                            {
                                result += "(";
                            }
                            else
                            {
                                result += s[j];
                            }
                        }
                    }
                }
                else if (temp == 0)
                {
                    result += s[i];
                }
            }
            // mỗi vòng chỉ xử lý 1 cập dấu {} nên phải chạy tới khi nào ko còn dấu {} nữa
            return reverseParentheses(result);
        }
        #endregion

        #region 4 - Exploring the Waters
        public static int[] AlternatingSums(int[] a)
        {
            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;
            for (int i = 0; i < a.Length; i += 2)
            {
                result[0] += a[i];
            }
            for (int i = 1; i < a.Length; i+=2)
            {
                result[1] += a[i];
            }
            return result;
        }
        public static string[] AddBorder(string[] picture)
        {
            string[] result = new string[picture.Length + 2];
            string tempfirst = "";
            string first = picture[0];
            for (int i = 0; i < first.Length + 2; i++)
            {
                tempfirst += "*";
            }
            result[0] = tempfirst;
            string temp = "";
            for (int i = 0; i < picture.Length; i++)
            {
                temp = "*" + picture[i] + "*";
                result[i + 1] = temp;
            }
            result[picture.Length + 1] = tempfirst;
            return result;
        }
        public static bool AreSimilar(int[] a, int[] b)
        {
            int dem = 0;
            int[] temp = (int[])b.Clone();
            for (int i = 0; i < temp.Length; i++)
            {
                if ( a[i] != temp[i])
                {
                    for (int j = i + 1; j < temp.Length; j++)
                    {
                        int first = temp[i];
                        temp[i] = temp[j];
                        temp[j] = first;

                        if (check(temp, a) == true)
                        {
                            return true;
                        }
                        temp = (int[])b.Clone();
                    }
                }
                else
                {
                    dem++;
                }
            }
            if (dem == a.Length) return true;
            return false;
        }
        public static bool check(int[] a , int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }      
            }
            return true;
        }
        public static int ArrayChange(int[] inputArray)
        {
            int result = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i + 1 < inputArray.Length)
                {
                    if (inputArray[i] >= inputArray[i + 1])
                    {
                        int temp = inputArray[i] + 1;
                        result += temp - inputArray[i + 1];
                        inputArray[i + 1] = inputArray[i] + 1;
                    }
                }
            }
            return result;
        }
        public static bool PalindromeRearranging(string inputString)
        {
            int[] a = new int[51]; // mảng để lưu số lần xuất hiện của mỗi phần tử
            bool[] b = new bool[51]; // dùng để kiểm tra xem vị trí đó xét chưa
            int count = 0, result = 0; // count là vị trí
            for (int i = 0; i < inputString.Length; i++)
            {
                if ( b[i] == false)
                {
                    a[count] = 1;
                    b[i] = true;
                    for (int j = i + 1; j < inputString.Length; j++)
                    {
                        if (inputString[i] == inputString[j])
                        {
                            a[count]++; // tăng số lần xuất hiện
                            b[j] = true;
                        }
                    }
                    count++;
                }
            }
            /*kiểm tra xem có chữ nào xuất hiện số lần lẻ hay ko , chỉ dc 1 hoặc 0 số dc xuất hiện số lần lẻ
             * VD : a b a b a  a xuất hiện số lần lẻ => đối xứng qua a
            */
            for (int i = 0; i < count; i++)
            {
                if ( a[i] % 2 != 0)
                {
                    result++;
                }
            }
            return result <= 1; // chỉ dc 1 chữ xuất hiện số lần lẻ vì sẽ đối xứng qua chữ đó
        }
        #endregion

        #region 5 - Island of Knowledge
        public static bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            if (yourLeft + yourRight == friendsLeft + friendsRight)
            {
                if (yourLeft == friendsLeft || yourLeft == friendsRight)
                {
                    return true;
                }
            }
            return false;
        }
        public static int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            int max = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == max)
                {
                    if ( i + 1 < inputArray.Length)
                    {
                        if (inputArray[i+1] < inputArray[i])
                        {
                            return inputArray[i] - inputArray[i + 1];
                        }
                    }
                    else
                    {
                        return inputArray[i] - inputArray[i - 1];
                    }
                }
            }
            return 0;
        }
        public static bool IsIPv4Address(string inputString)
        {
            string[] temp = inputString.Split('.');
            int dem = 0;
            if ( temp.Length == 4)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if ( temp[i] != "")
                    {
                        int result = 0;
                        if ( Int32.TryParse(temp[i],out result) == true)
                        if (result >= 0 && result <= 255)
                        {
                            dem++;
                        }
                    }
                }
            }
            if (dem == temp.Length) return true;
            return false;
        }
        public static int AvoidObstacles(int[] inputArray)
        {
            List<int> list = inputArray.ToList();
            for (int i = 1; i < inputArray.Max() + 1; i++)
            {
                if ( list.All(element => element % i != 0) )
                {
                    return i;
                }
            }
            return list.Max() + 1;
        }
        public static int[][] BoxBlur(int[][] image)
        {
            int[][] result = null;
            List<List<int>> temp = new List<List<int>>();
            for (int i = 0; i < image.Length - 2; i++) // mỗi lần chọn ra 3 số nên phải - 2 để tránh chọn 2 hoặc 1 số cuối
            {
                List<int> list = new List<int>();
                for (int j = 0; j < image[i].Length - 2; j++)
                {
                    // xét ma trận cấp 3 từ vị trì i , j
                    int sum = 0;
                    for (int x = i; x < i + 3; x++)
                    {
                        for (int y = j; y < j + 3; y++)
                        {
                            sum += image[x][y];
                        }
                    }
                    list.Add(Convert.ToInt32(sum / 9));
                }
                temp.Add(list);
            }
            // chuyển về mảng trong mảng kiểu int[][]
            return result = temp.Select( list => list.ToArray()).ToArray();
        }
        public static int[][] Minesweeper(bool[][] matrix)
        {
            int[][] result = null;
            List<List<int>> Temp = new List<List<int>>();
            for (int i = 0; i < matrix.Length; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    int dem = 0;
                    for (int x = i - 1; x < i + 2; x++)
                    {
                        if ( x >= 0 )
                        {
                            for (int y = j - 1; y < j + 2; y++)
                            {
                                if ( y >= 0)
                                {
                                    if ((y < matrix[i].Length && x < matrix.Length))
                                    {
                                        if (x == i && y == j)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            if (matrix[x][y] == true)
                                            {
                                                dem++;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                    list.Add(dem);
                }
                Temp.Add(list);
            }
            return result = Temp.Select(list => list.ToArray()).ToArray();
        }
        #endregion

        #region 6 - Rains of Reason
        public static int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                {
                    list.Add(substitutionElem);
                }
                else
                {
                    list.Add(inputArray[i]);
                }
            }
            return list.ToArray();
        }
        public static bool EvenDigitsOnly(int n)
        {
            List<int> list = new List<int>();
            while(n != 0)
            {
                if ( n % 10 != 0)
                {
                    list.Add(n % 10);
                }
                n = n / 10;
            }
            return list.All(element => element % 2 == 0);
        }
        public static bool VariableName(string name)
        {
            if (Convert.ToInt32(name[0]) >= 48 && Convert.ToInt32(name[0]) <= 57 ) return false;
            if (name.All(c => Convert.ToInt32(c) >= 65 && Convert.ToInt32(c) <= 90 // chữ in
                           || Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122 // chữ thường
                           || Convert.ToInt32(c)>= 48 && Convert.ToInt32(c) <= 57 // số
                           || c == '_' )) return true;
            return false;
        }
        public static string alphabeticShift(string inputString)
        {
            string result = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                int temp = Convert.ToInt32(inputString[i]) + 1;
                if ( temp > 122)
                {
                    temp = 96 + (temp - 122);
                }
                result += Convert.ToChar(temp).ToString();
            }
            return result;
        }
        public static bool ChessBoardCellColor(string cell1, string cell2)
        {
            return (cell1.All(c => Convert.ToInt32(c) % 2 == 0) || cell1.All(c => Convert.ToInt32(c) % 2 != 0))
                == (cell2.All(c => Convert.ToInt32(c) % 2 == 0) || cell2.All(c => Convert.ToInt32(c) % 2 != 0));
        }
        #endregion

        #region 7 - Through the Fog
        public static int CircleOfNumbers(int n, int firstNumber)
        {
             return firstNumber + n / 2 > n - 1 ? firstNumber + n / 2 - n : firstNumber + n / 2;
        }
        public static int DepositProfit(double deposit, int rate, int threshold)
        {
            // đổi tham int deposit => double deposit
            int year = 0;
            while ( deposit < threshold)
            {
                // vế sau trả về double , nếu lưu qua int thì sẽ bị mất giá trị sau dấu ,
                deposit += rate * deposit / 100;
                year++;
            }
            return year;
        }
        public static int AbsoluteValuesSumMinimization(int[] a)
        {
            int result = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    temp += Math.Abs(a[j] - a[i]);
                }
                if ( dictionary.ContainsKey(temp) == false)
                {
                    dictionary.Add(temp, a[i]);
                }
            }
            return result = dictionary[dictionary.Keys.ToList().Min()];
        }
        public static bool StringsRearrangement(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            { //for each string
                string[] bank = inputArray; //copy the string array to form a 'word bank'
                string[] good = new string[bank.Length]; //create an empty array to build a solution
                good[0] = bank[i]; //begin the solution with each word
                bank = pop(bank, i); //remove the beginning word from the word bank
                if (continueSwap(good, bank, 0)) //if a solution is found using this beginning word, return true
                    return true;
            }
            return false; //all words have failed to begin a valid sequence
        }
        public static bool continueSwap(string[] good, string[] bank, int step)
        {
            for (int i = 0; i < bank.Length; i++)
            { //for each remaining word in bank
                if (canSwap(good[step], bank[i]))
                { //can the last known good word swap a letter to form this word in bank?
                    if (bank.Length == 1) //is this the last word in bank?
                        return true; //a solution is found!
                                     //if not, there are more word(s) to test
                    string[] better = good; //copy the good sequence as not to alter it for later iterations
                    better[step + 1] = bank[i]; //add the next good word to the sequence
                    string[] removed = pop(bank, i); //remove this word from word bank
                    if (continueSwap(better, removed, step + 1)) //keep going until no words in bank match, or the final word in bank matches
                        return true;
                }//end swap check
            }//end of each word in bank
            return false; //no words remaining in word bank can continue this sequence
        }
        public static bool canSwap(string a, string b)
        {
            char[] ac = a.ToCharArray();
            char[] bc = b.ToCharArray();
            int different = 0; //count the descrepensies between characters
            for (int i = 0; i < ac.Length; i++)
                if (ac[i] != bc[i])
                    different++;
            return (different == 1);    //words can swap a character to match if there is exactly 1 different letter
        }
        public static string[] pop(string[] inputArray, int pop)
        { //used to return an array missing element at index 'pop'
            string[] popped = new string[inputArray.Length - 1];
            for (int i = 0; i < pop; i++)
                popped[i] = inputArray[i];
            for (int i = pop; i < popped.Length; i++)
                popped[i] = inputArray[i + 1];
            return popped;
        }
        #endregion
    }
}
