
namespace Covariance
{
    interface IIndex<out T>
    {
        T this[int index] { get; }
        int count { get; }
    }

}
