using System;

class task3
{
	static int binarySearch(int[] arr, int l, int r, int n)
	{
		while (r >= l)
		{
			int mid = l + (r - l) / 2;


			if (arr[mid] == n)
				return mid;

			if (arr[mid] > n)
				return binarySearch(arr, l, mid - 1, n);


			return binarySearch(arr, mid + 1, r, n);
		}


		return -1;
	}

	public static void Main()
	{
		Console.WriteLine("Enter size of an array: ");
		int z = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[z];

		Console.WriteLine("Enter elements of an array: ");
		for (int i = 0; i < z; i++)
        {
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Enter number that you want to find its index: ");
		int n = Convert.ToInt32(Console.ReadLine());

		int result = binarySearch(arr, 0, n - 1, n);

		if (result == -1)
			Console.WriteLine("Element does not exist in series");
		else
			Console.WriteLine("Element found at index " + result);
	}
}