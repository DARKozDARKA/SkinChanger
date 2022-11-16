using CodeBase.Customization;
using CodeBase.StaticData.Enums;

namespace CodeBase.Services.CharacterCustomizator
{
    public interface ICharacterCustomizator
    {
        void SetCustomizationBase(CustomizationBase customizationBase);
        void SetNextCustom(CustomizationPartType type);
        void SetPrevoiusCustom(CustomizationPartType type);
    }
}