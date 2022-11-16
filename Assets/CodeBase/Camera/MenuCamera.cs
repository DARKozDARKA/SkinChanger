using UnityEngine;

namespace CodeBase.CameraScripts
{
    public class MenuCamera : MonoBehaviour
    {
        [SerializeField]
        private Animator _animator;

        private readonly int _goToMainMenu = Animator.StringToHash(MainMenu);
        private readonly int _goToCustomizationMenu = Animator.StringToHash(CustomizationMenu);

        private const string MainMenu = "GoToMainMenu";
        private const string CustomizationMenu = "GoToCustomizationMenu";

        public void SetMainMenuPosition() => 
            _animator.SetTrigger(_goToMainMenu);

        public void SetCustomizationMenuPosition() => 
            _animator.SetTrigger(_goToCustomizationMenu);
    }
}
