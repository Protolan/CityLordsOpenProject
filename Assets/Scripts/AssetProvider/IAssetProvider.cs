using UnityEngine;

namespace AssetProvider
{
    
    public interface IAssetProvider
    {
        T GetObject<T>(string path) where T : Object;
    }
}