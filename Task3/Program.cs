namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Quaternion q1 = new Quaternion(1, 2, 3, 4);
            Quaternion q2 = new Quaternion(5, 6, 7, 8);

            Quaternion sum = q1 + q2;
            Quaternion difference = q1 - q2;
            Quaternion product = q1 * q2;

            double norm = q1.Norm();
            Quaternion conjugate = q1.Conjugate();
            Quaternion inverse = q1.Inverse();

            bool isEqual = q1 == q2;
            bool isNotEqual = q1 != q2;

            double[,] rotationMatrix = q1.ToRotationMatrix();
            Quaternion fromMatrix = Quaternion.FromRotationMatrix(rotationMatrix);

            Console.WriteLine("Quaternion Sum: " + $"W: {sum.W}, X: {sum.X}, Y: {sum.Y}, Z: {sum.Z}");
            Console.WriteLine("Quaternion Difference: " + $"W: {difference.W}, X: {difference.X}, Y: {difference.Y}, Z: {difference.Z}");
            Console.WriteLine("Quaternion Product: " + $"W: {product.W}, X: {product.X}, Y: {product.Y}, Z: {product.Z}");
            Console.WriteLine("Quaternion Norm: " + norm);
            Console.WriteLine("Quaternion Conjugate: " + $"W: {conjugate.W}, X: {conjugate.X}, Y: {conjugate.Y}, Z: {conjugate.Z}");
            Console.WriteLine("Quaternion Inverse: " + $"W: {inverse.W}, X: {inverse.X}, Y: {inverse.Y}, Z: {inverse.Z}");
            Console.WriteLine("Quaternions are Equal: " + isEqual);
            Console.WriteLine("Quaternions are Not Equal: " + isNotEqual);

            Console.WriteLine("Rotation Matrix:");
            for (int i = 0; i < rotationMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < rotationMatrix.GetLength(1); j++)
                {
                    Console.Write(rotationMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Quaternion from Rotation Matrix: " + $"W: {fromMatrix.W}, X: {fromMatrix.X}, Y: {fromMatrix.Y}, Z: {fromMatrix.Z}");
        }
    }
}