namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        //### Calculate deepest pit
        int result = GetPitDepth(points);

        return result;

        //throw new NotImplementedException("Not completed yet");
    }

    private static int GetPitDepth(int[] A)
    {
        //### Note - Algorithm used to calculate depth
        // depth = min(A[P] - A[Q], A[R] - A[Q])
        
        if (A == null || A.Length < 3)
            return -1;

        int length = A.Length;
        int i = 0;
        int maxDepth = -1;

        while (i < length - 1)
        {
            //### Look for strictly decreasing start
            if (A[i] <= A[i + 1])
            {
                i++;
                continue;
            }

            int p = i;

            //### Walk downward to Q
            while (i < length - 1 && A[i] > A[i + 1])
                i++;

            int q = i;

            //### If no room to rise, break
            if (q == length - 1)
                break;

            //### Walk upward to R
            while (i < length - 1 && A[i] < A[i + 1])
                i++;

            int r = i;

            //### Valid pit must have P < Q < R
            if (p < q && q < r)
            {
                int leftDrop = A[p] - A[q];
                int rightRise = A[r] - A[q];
                int depth = Math.Min(leftDrop, rightRise);

                if (depth > maxDepth)
                    maxDepth = depth;
            }
        }


        return maxDepth;

    }

}
