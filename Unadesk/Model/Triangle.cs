namespace Unadesk.Model
{
    /// <summary>
    /// Класс описывающий треугольник.
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Первый катет треугольника.
        /// </summary>
        public int legA { get; set; }

        /// <summary>
        /// Второй катет треугольника.
        /// </summary>
        public int legB { get; set; }

        /// <summary>
        /// Гипотенуза.
        /// </summary>
        public int hypotenuse { get; set; }

        public Triangle(int legA, int legB, int hypotenuse)
        {
            this.legA = legA;
            this.legB = legB;
            this.hypotenuse = hypotenuse;
        }
    }
}
