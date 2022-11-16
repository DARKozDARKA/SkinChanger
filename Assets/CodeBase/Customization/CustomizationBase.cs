using System.Collections.Generic;
using System.Linq;
using CodeBase.StaticData.Enums;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace CodeBase.Customization
{
    public class CustomizationBase : SerializedMonoBehaviour
    {
        [OdinSerialize]
        public Dictionary<CustomizationPartType, CustomizationPart> AllParts;

        [Button]
        private void CollectInChildrens() => 
            AllParts = GetComponentsInChildren<CustomizationPart>().ToDictionary(_ => _.Type, _ => _);
    }
}