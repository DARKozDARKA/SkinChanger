using UnityEngine;

namespace CodeBase.Services.Data
{
    public interface IStaticDataService
    {
        T LoadResource<T>(string path) where T : Object;
        T[] LoadResources<T>(string path) where T : Object;
    }
}