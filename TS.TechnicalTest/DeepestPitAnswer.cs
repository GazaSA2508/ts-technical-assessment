namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        throw new NotImplementedException("Not completed yet");
    }

    private static int GetPitDepth(int[] points)
    {
        //### Note - Algorithm used to calculate depth
        // depth = min(A[P] - A[Q], A[R] - A[Q])

        //if (points == null) throw new ArgumentNullException(nameof(points));
        ArgumentNullException.ThrowIfNull(points);

        int length = points.Length;

        if (length < 3) 
            return -1;


        int maxDepth = -1;



        return maxDepth;

    }
}
