using CodeBase.Customization;
using CodeBase.StaticData.Enums;

namespace CodeBase.Services.CharacterCustomizator
{
    public class CharacterCustomizator : ICharacterCustomizator
    {
        private CustomizationBase _customizationBase;
        public void SetCustomizationBase(CustomizationBase customizationBase) => 
            _customizationBase = customizationBase;

        public void SetNextCustom(CustomizationPartType type) => 
            _customizationBase.AllParts[type].SetNext();
        
        public void SetPrevoiusCustom(CustomizationPartType type) => 
            _customizationBase.AllParts[type].SetPrevious();
    }
}