using UnityEngine;

namespace CodeBase.Services.UI
{
    public interface IWindowService
    {
        void SetCanvas(GameObject canvas);
        void OpenMainMenu();
        void OpenCustomizationMenu();
    }
}