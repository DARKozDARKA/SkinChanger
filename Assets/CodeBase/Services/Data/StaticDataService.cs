using UnityEngine;
using Object = UnityEngine.Object;

namespace CodeBase.Services.Data
{
    public class StaticDataService : IStaticDataService
    {
        public T LoadResource<T>(string path) where T : Object =>
            Resources.Load<T>(path);

        public T[] LoadResources<T>(string path) where T : Object =>
            Resources.LoadAll<T>(path);
    }
}