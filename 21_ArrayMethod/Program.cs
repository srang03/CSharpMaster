namespace _21_ArrayMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 55, 100, 1, 2, 3, 55, 410, 1000, 50 };

            //Print(arr);
            // 오름차순 정렬
            // Array.Sort(arr);

            // 내림차순 정렬
            // Array.Reverse(arr);
            //Print(arr);

            // 첫 번째 위치 검색
            int firstIndex = Array.IndexOf(arr, 55);
            //Console.WriteLine(arr[firstIndex]);

            // 마지막 위치 검색
            int LastIndex = Array.IndexOf(arr, 55);
            // Console.WriteLine(arr[LastIndex]);

            // 배열 초기화
            // Array.Clear(arr, 0, 3);
            // Print(arr);

            // 배열 요소 복사
            int[] copy = new int[10];
            // arr의 index값이 1인 요소부터 복사를 할거야! 그리고 copy 배열에 0~9까지 요소를 복사해줘
            Array.Copy(arr, 1, copy, 0, 9);
            Print(copy);


            // 배열 자체를 복사
            int[] clone = (int[])arr.Clone();
        }


        static void Print(int[] arr)
        {
            foreach (int num in arr) Console.WriteLine(num);
        }
    }
}