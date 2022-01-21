using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of basic 13 algos");
            System.Console.WriteLine("************************");
            PrintNumbers();
            System.Console.WriteLine("************************");
            PrintOdds();
            System.Console.WriteLine("************************");
            PrintSum();
            System.Console.WriteLine("************************");
            int[] temp = new int[]{1,3,15,7,9,-3,6};
            LoopArray(temp);
            System.Console.WriteLine("************************");
            FindMax(temp);
            System.Console.WriteLine("************************");
            GetAverage(temp);
            System.Console.WriteLine("************************");
            // System.Console.WriteLine(OddArray());
            int[] newArr = OddArray();
            foreach (int num in newArr)
            {
                System.Console.WriteLine(num);
            }
            System.Console.WriteLine("************************");
            int total = GreaterThanY(temp, 7);
            System.Console.WriteLine(total);
            System.Console.WriteLine("************************");
            SquareArrayValue(temp);
            System.Console.WriteLine("************************");
            NoNegs(temp);
            System.Console.WriteLine("************************");
            MMA(temp);
            System.Console.WriteLine("************************");
            ShiftValues(temp);
            System.Console.WriteLine("************************");
            object[] nObj = NumToString(temp);
            foreach (var item in nObj)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("************************");



        }

        public static void PrintNumbers(){
            for(int i = 1; i <= 255; i++) {
                System.Console.WriteLine(i);
            }
        }

        public static void PrintOdds() {
            for(int j = 1; j <= 255; j++) {
                if(j % 2 == 1) {
                    System.Console.WriteLine(j);
                }
            }
        }

        public static void PrintSum(){
            int sum = 0;
            for(int k =0; k <= 255; k++){
                sum += k;
                System.Console.WriteLine($"New number: {k} sum: {sum}");
            }
        }


        public static void LoopArray(int[] nums){

            foreach (int num in nums)
            {
                System.Console.WriteLine($"{num}");
            }
        }


        public static void FindMax(int[] nums){
            int max = nums[0];
            foreach (int num in nums) {
                if(max < num) {
                    max = num;
                }
            }
            System.Console.WriteLine(max);
        }

        public static void GetAverage(int[] nums) {
            int sum=0;
            int avg=0;
            foreach (int num in nums)
            {
                sum += num;
            }
            avg = sum / nums.Length;
            System.Console.WriteLine(avg);
        }

        public static int[] OddArray(){
            List<int> tempList = new List<int>();
            for(int n = 1; n <=255; n++){
                if(n % 2 == 1) {
                    tempList.Add(n);
                }
            }
            int arrSize = tempList.Count;
            int[] newArray = new int[arrSize];
            for(int z = 0; z < arrSize; z++) {
                newArray[z] = tempList[z];
            }
            return newArray;
        }

        public static int GreaterThanY(int[] nums, int y) {
            int sum = 0;
            foreach (int num in nums)
            {
                if(num > y) {
                    sum += 1;
                }
            }
            return sum;
        }

        public static void SquareArrayValue(int[] nums) {
            foreach (int num in nums)
            {
                System.Console.WriteLine(num);
            }
            int[] newInt = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++){
                newInt[i] = nums[i]*nums[i];
            }
            foreach (int num1 in newInt)
            {
                System.Console.WriteLine(num1);
            }
        }

        public static void NoNegs(int[] nums){
            foreach (int num in nums)
            {
                if(num > 0){
                System.Console.WriteLine(num);
                } else{
                    System.Console.WriteLine(0);
                }
            }
        }


        public static void MMA(int[] nums){
            int max = nums[0];
            int min = nums[0];
            int avg = 0;
            foreach (int num in nums)
            {
                if(max < num) {
                    max = num;
                }
                if(min > num) {
                    min = num;
                }
                avg += num;
            }
            avg = avg / nums.Length;
            System.Console.WriteLine($"Max: {max} -- Min: {min} -- Avg: {avg}");
        }

        public static void ShiftValues(int[] nums) {
            int[] newNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if(i == (nums.Length -1)) {
                    newNums[i] = 0;
                }else{
                    newNums[i] = nums[i+1]; 
                }
            }
            foreach (int num in newNums)
            {
                System.Console.WriteLine(num);
            }
        }

        public static object[] NumToString(int[] nums){
            object[] obj = new object[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > 0) {
                    obj[i] = nums[i];
                }else{
                    obj[i] = "Dojo";
                }
            }
            return obj;
        }









    }
}
