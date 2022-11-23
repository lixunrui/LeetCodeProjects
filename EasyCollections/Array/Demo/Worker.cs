using System;
using System.Collections.Generic;

public class Worker
{
    public static int Run(int[] a)
    {
        System.Console.WriteLine("At Run");

        List<int> missing = new List<int>();
        List<int> store = new List<int>();
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (!store.Contains(i + 1) && i + 1 != a[i])
                missing.Add(i + 1);
            if (i + 1 < a[i])
                store.Add(a[i]);
            else
                missing.Remove(a[i]);
            if (missing.Count == 0)
                count++;
        }
        return count;
        System.Console.WriteLine("End Run");
    }

    public static int Min(int[] A)
    {

        int ans = A[0];
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] < ans)
            {
                ans = A[i];
            }
        }
        return ans;
    }
}
