
namespace Covariance
{
    class ShapeDisplay : IDisplay<Shape>
    {
        public string Show(Shape shape)
        {
            return string.Format("{0} width :{1},height:{2}", shape.GetType().Name, shape.Width, shape.Height);
        }
    }
}
