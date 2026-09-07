namespace ShortPrepareTasks
{
    internal class Mediana
    {
        private readonly int[] arr = [5, 3, 1, 2, 4];

        public int GetMediana()
        {
            var lenght = arr.Length;
            Array.Sort(arr);

            var middle = lenght / 2;
            if (lenght % 2 == 0)
            {
                //licz średnią
                return Convert.ToInt32( (arr[middle] + arr[middle - 1]) / 2.0);
            }
            else
            {
                return arr[middle];
            }
        }
    }
}
