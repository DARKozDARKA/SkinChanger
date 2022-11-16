using CodeBase.Customization;
using UnityEngine;

namespace CodeBase.Services.Factory
{
    public interface IPrefabFactory
    {
        CustomizationBase CreateCustomizationBase(Vector3 at);
        GameObject CreateUI();
    }
}