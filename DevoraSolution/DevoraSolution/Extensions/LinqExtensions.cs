
namespace DevoraSolution.Extensions
{
    public static class LinqExtensions
    {
        public static void RemoveRange<T>(this IList<T> collections, IEnumerable<T> items)
        {
            foreach (var x in items)
                collections.Remove(x);
        }
    }
}
