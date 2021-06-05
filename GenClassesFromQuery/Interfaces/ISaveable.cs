using System.Threading.Tasks;

namespace GenClassesFromQuery.Interfaces
{
    public interface ISaveable
    {
        string Filename { get; }
        string DefaultExtension { get; }

        Task SaveAsync(string fileName);
    }
}