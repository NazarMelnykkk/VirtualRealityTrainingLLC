using UnityEngine;

public class ButtonToggleSettings : ButtonCustomBase
{
    [SerializeField] private bool _togleValue;

    public override void Click()
    {
        base.Click();
        PlaySound();

    }

    private void PlaySound()
    {
        References.Instance.AudioHandler.PlaySound(SoundConstants.UICLICK_TYPE, SoundConstants.UICLICK);
    }
}
