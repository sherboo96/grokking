namespace grokking;
public class BinarySearch
{
	public int binarySearch(int[] arrList, int item)
	{
		int min = 0;
		int max = arrList.Length - 1;

		while (min <= max)
		{
			int mid = (min + max) / 2;
			int midItem = arrList[mid];

			if (midItem == item)
				return mid;
			else if (item > midItem)
				min = mid + 1;
			else
				max = mid - 1;
		}

		return -1;
	}
}

