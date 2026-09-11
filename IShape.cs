using System.Windows.Controls;

namespace ShapesDrawing
{
    /// <summary>
    /// Общий интерфейс для фигур, которые можно нарисовать на холсте
    /// и переместить по осям X и Y.
    /// </summary>
    public interface IShape
    {
        void Draw(Canvas canvas);
        void Move(int dx, int dy);
    }
}
