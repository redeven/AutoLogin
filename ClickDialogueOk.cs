using System; 
using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace AutoLogin;

public sealed unsafe class ClickDialogueOk : ClickBase<ClickDialogueOk, AddonSelectYesno>
{
    public ClickDialogueOk(IntPtr addon = default)
        : base("Dialogue", addon)
    {
    }

    public static implicit operator ClickDialogueOk(IntPtr addon) => new(addon);

    public static ClickDialogueOk Using(IntPtr addon) => new(addon);

    [ClickName("select_offset")]
    public void WithButton(AtkComponentButton* button)
        => this.ClickAddonButton(button, 0);
}
