using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace AssetProvider
{
    public class ResourceAssetProvider : IAssetProvider
    {
        public T GetObject<T>(string path) where T : Object => Resources.Load<T>(path);
    }
}