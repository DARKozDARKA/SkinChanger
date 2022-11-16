using CodeBase.Customization;
using CodeBase.Services.AssetManagment;
using CodeBase.Services.Data;
using CodeBase.StaticData.Strings;
using CodeBase.Tools;
using UnityEngine;
using Zenject;

namespace CodeBase.Services.Factory
{
    public class PrefabFactory : IPrefabFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly DiContainer _container;

        public PrefabFactory(DiContainer container, IAssetProvider assetProvider, IStaticDataService staticDataService)
        {
            _assetProvider = assetProvider;
            _container = container;
        }

        public CustomizationBase CreateCustomizationBase(Vector3 at) => 
            _assetProvider.Instantiate(PrefabsPath.CustomizationBase, at)
                .GetComponent<CustomizationBase>();

        public GameObject CreateUI() =>
            _assetProvider.Instantiate(PrefabsPath.UI)
                .With(_ => _container.InjectGameObject(_));
    }
}