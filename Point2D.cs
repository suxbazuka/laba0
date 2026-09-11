using System;

namespace ShapesDrawing
{
    /// <summary>
    /// Класс точки с координатами X и Y.
    /// </summary>
    public class Point2D
    {
        // Чтение свойств доступно отовсюду, изменение — только изнутри класса
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Смещение координаты на заданную величину (а не простое присваивание,
        // поэтому реализовано как метод, а не сеттер свойства)
        public void AddX(int x)
        {
            X += x;
        }

        public void AddY(int y)
        {
            Y += y;
        }
    }
}
