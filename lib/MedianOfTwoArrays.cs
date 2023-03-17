namespace LeetCode;

public class MedianOfTwoArrays
{
    public double Execute(int[] arr1, int[] arr2)
    {
        int l1 = arr1.Length;
        int l2 = arr2.Length;

        if (l1 > l2)
        {
            return Execute(arr2, arr1);
        }

        int start = 0;
        int end = l1;

        double median = 0;

        while (start <= end)
        {

            int p1 = (start + end) / 2;
            int p2 = (1 + l1 + l2) / 2 - p1;

            int arr1Left = (p1 > 0) ? arr1[p1 - 1] : int.MinValue;
            int arr1Right = (p1 < l1) ? arr1[p1] : int.MaxValue;
            int arr2Left = (p2 > 0) ? arr2[p2 - 1] : int.MinValue;
            int arr2Right = (p2 < l2) ? arr2[p2] : int.MaxValue;

            if ((arr1Left <= arr2Right) && (arr2Left <= arr1Right))
            {
                if ((l1 + l2) % 2 == 0)
                {
                    median = ((Math.Max(arr1Left, arr2Left)) + Math.Min(arr1Right, arr2Right)) / 2.0;
                    break;
                }
                else
                {
                    median = Math.Max(arr1Left, arr2Left);
                    break;
                }
            }
            else if (arr1Left > arr2Right)
            {
                end = p1 - 1;
            }
            else
            {
                start = p1 + 1;

            }

        }

        return median;

    }
    // public double Execute(int[] nums1, int[] nums2)
    // {
    //     int l1 = nums1.Length;
    //     int l2 = nums2.Length;

    //     if (l1 > l2)
    //     {
    //         return Execute(nums2, nums1);
    //     }

    //     double median = -1;

    //     int start = 0;
    //     int end = l1;
    //     while (start <= end)
    //     {
    //         int p1 = (start + end) / 2;
    //         int p2 = (l1 + l2 + 1) / 2 - p1;

    //         int maxLeft1 = (p1 == 0) ? Int32.MinValue : nums1[p1 - 1];
    //         int minRight1 = (p1 == l1) ? Int32.MaxValue : nums1[p1];

    //         int maxLeft2 = (p2 == 0) ? Int32.MinValue : nums2[p2 - 1];
    //         int minRight2 = (p2 == l2) ? Int32.MaxValue : nums2[p2];

    //         if ((maxLeft1 <= minRight2) && (maxLeft2 <= minRight1))
    //         {
    //             if ((l1 + l2) % 2 == 0)
    //             {
    //                 median = ((Math.Max(maxLeft1, maxLeft2)) + Math.Min(minRight1, minRight2)) / 2.0;
    //                 break;
    //             }
    //             else
    //             {
    //                 median = Math.Max(maxLeft1, maxLeft2);
    //                 break;
    //             }
    //         }

    //         else if (maxLeft1 > minRight2)
    //         {
    //             end = p1 - 1;
    //         }
    //         else
    //         {
    //             start = p1 + 1;
    //         }
    //     }

    //     return median;
}
