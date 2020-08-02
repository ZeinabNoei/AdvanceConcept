
namespace Covariance
{
    interface IDisplay<in T>
    {
        string Show(T item);
    }
}
