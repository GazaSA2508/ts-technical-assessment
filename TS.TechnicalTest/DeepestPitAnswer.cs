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

    /// <summary>
    /// Finds the deepest pit in an array while enforcing the following constraints:
    /// Length N within range of [1..1,000,000]
    /// Each element within range of [0..1,000,000]
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    private static int GetPitDepth(int[] A)
    {
        //### Note - Algorithm used to calculate depth
        // depth = min(A[P] - A[Q], A[R] - A[Q])

        ArgumentNullException.ThrowIfNull(A);
        
        int length = A.Length;

        //### Do validation for rules required
        Validate(length, A);

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

            //### Strictly decreasing run (P to Q) (Walk downward to Q)
            while (i < length - 1 && A[i] > A[i + 1])
                i++;

            int q = i;

            //### If no room to rise, break
            if (q == length - 1)
                break;

            //### Strictly increasing run (Q to R) (Walk upward to R)
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

    private static void Validate(int length, int[] A)
    {
        //### Validate array length
        if (length < 1 || length > 1000000)
        {
            var error = $"Array length N={length} is outside the allowed range [1..1,000,000].";

            Console.WriteLine($"ERROR: {error}");

            throw new ArgumentOutOfRangeException(nameof(A), error);

        }

        //### Validate element value
        for (int k = 0; k < length; k++)
        {
            if (A[k] < 0 || A[k] > 1000000) 
            {
                var error = $"Array element A[{k}]={A[k]} is outside the allowed range [0..1,000,000].";

                Console.WriteLine($"ERROR: {error}");

                throw new ArgumentOutOfRangeException(nameof(A), error);

            }
        }

    }

}
