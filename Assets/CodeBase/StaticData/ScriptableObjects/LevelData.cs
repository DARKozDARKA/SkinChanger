using CodeBase.Infrastructure.States;
using CodeBase.StaticData.Strings;
using Sirenix.OdinInspector;
using UnityEngine;

namespace CodeBase.StaticData.ScriptableObjects
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "StaticData/LevelData")]
    public class LevelData : ScriptableObject
    {
        [ReadOnly]
        public Vector3 CharacterSpawnPoint;

        [Button(ButtonSizes.Medium)]
        private void Collect()
        {
            CharacterSpawnPoint = GameObject.FindWithTag(Tags.PrefabSpawnPoint).transform.position;
        }
    }
}