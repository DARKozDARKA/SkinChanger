using CodeBase.Tools;
using CodeBase.UI;
using UnityEngine;

namespace CodeBase.Services.UI
{
    public class WindowService : IWindowService
    {
        private MainMenuWindow _mainMenu;
        private CustomizationWindow _customization;

        private Window _activeWindow;
        
        
        public void SetCanvas(GameObject canvas)
        {
            _mainMenu = canvas.GetComponentInChildren<MainMenuWindow>()
                .With(_ => _.Close());
            
            _customization = canvas.GetComponentInChildren<CustomizationWindow>()
                .With(_ => _.Close());
        }

        public void OpenMainMenu()
        {
            _activeWindow?.Close();
            _activeWindow = _mainMenu;
            _activeWindow.Open();
        }

        public void OpenCustomizationMenu()
        {
            _activeWindow?.Close();
            _activeWindow = _customization;
            _activeWindow.Open();
        }
    }
}