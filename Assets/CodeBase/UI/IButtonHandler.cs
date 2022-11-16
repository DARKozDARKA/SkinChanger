using System;

namespace CodeBase.UI
{
    public interface IButtonHandler
    {
        Action Pressed { get; set; }
    }
}