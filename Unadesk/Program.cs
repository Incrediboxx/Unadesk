using Unadesk.Helpers;

namespace Unadesk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = TriangleHelper.GetTriangle(false); ;
            TriangleHelper.CheckTriangleType(triangle);
        }
    }
}
