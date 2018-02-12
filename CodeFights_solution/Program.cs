using System;
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

            #region alternatingSums

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
    }
}
