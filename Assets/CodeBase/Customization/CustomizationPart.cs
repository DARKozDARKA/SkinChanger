using System;
using System.Collections.Generic;
using CodeBase.StaticData.Enums;
using JetBrains.Annotations;
using Sirenix.OdinInspector;
using UnityEngine;

namespace CodeBase.Customization
{
    [Serializable]
    public class CustomizationPart : MonoBehaviour
    {
        [SerializeField]
        private CustomizationPartType _type;
    
        [SerializeField]
        private List<GameObject> _elements = new();
    
        [SerializeField, CanBeNull]
        private GameObject _currentActiveItem;
    
        private int _currentElementIndex;
        public CustomizationPartType Type => _type;
        private int ElementsAmount => _elements.Count;
    

        public void SetNext()
        {
            _currentElementIndex++;
            if (_currentElementIndex + 1 > ElementsAmount)
                _currentElementIndex = 0;
        
            ShowItem();
        }

        public void SetPrevious()
        {
            _currentElementIndex--;
            if (_currentElementIndex < 0)
                _currentElementIndex = ElementsAmount - 1;
        
            ShowItem();
        }

        private void ShowItem()
        {
            if (_currentActiveItem != null)
                _currentActiveItem.SetActive(false);
            _currentActiveItem = _elements[_currentElementIndex];
            _currentActiveItem.SetActive(true);
        }

        [Button]
        private void CollectInChildrens()
        {
            _elements.Clear();
            foreach (Transform child in transform)
            {
                if (child.gameObject.activeSelf)
                    _currentActiveItem = child.gameObject;
            
                _elements.Add(child.gameObject);
            }
           
        }
    }
}