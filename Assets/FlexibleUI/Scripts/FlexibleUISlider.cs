using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class FlexibleUISlider : FlexibleUI{

    public enum SliderType { Default}

    public FlexibleUISliderData Data;
    public SliderType Type;

    private Image backgroundImage;
    private Image fillImage;
    private Image handleImage;
    private Slider slider;

    public override void Awake()
    {
        slider = GetComponent<Slider>();
        backgroundImage = transform.Find("Background").GetComponent<Image>();
        fillImage = slider.fillRect.GetComponent<Image>();
        handleImage = slider.handleRect.GetComponent<Image>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Selectable.Transition transition = Selectable.Transition.SpriteSwap;
        Sprite handleSprite = Data.DefaultHandleSprite;
        SpriteState handleSpriteState = Data.DefaultHandleSpriteState;
        Sprite backgroundSprite = Data.BackgroundSprite;
        Sprite fillSprite = Data.DefaultFillSprite;
        ColorBlock colors = new ColorBlock();

        colors.colorMultiplier = 1;
        colors.fadeDuration = 0.1f;

        switch(Type)
        {
            case SliderType.Default:
                transition = Selectable.Transition.ColorTint;

                colors.normalColor = Data.NormalColor;
                colors.highlightedColor = Data.HighlightedColor;
                colors.pressedColor = Data.PressedColor;
                colors.disabledColor = Data.DisableColor;
                break;
        }

        slider.transition = transition;
        slider.colors = colors;
        slider.spriteState = handleSpriteState;
        backgroundImage.sprite = backgroundSprite;
        handleImage.sprite = handleSprite;
        fillImage.sprite = fillSprite;
    }
}
