using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class FlexibleUIToggle : FlexibleUI
{

    public enum ToggleType { Default }

    public FlexibleUIToggleData Data;
    public ToggleType Type;

    private Image backgroundImage;
    private Image checkmarkImage;
    private Toggle toggle;

    public override void Awake()
    {
        toggle = GetComponent<Toggle>();
        backgroundImage = toggle.image;
        checkmarkImage = toggle.graphic.GetComponent<Image>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Selectable.Transition transition = Selectable.Transition.SpriteSwap;
        Sprite sprite = Data.DefaultSprite;
        Sprite checkmarkSprite = Data.CheckmarkSprite;
        SpriteState spriteState = Data.DefaultSpriteState;
        ColorBlock colors = new ColorBlock();

        colors.colorMultiplier = 1;
        colors.fadeDuration = 0.1f;


        switch (Type)
        {
            case ToggleType.Default:
                transition = Selectable.Transition.ColorTint;

                colors.normalColor = Data.NormalColor;
                colors.highlightedColor = Data.HighlightedColor;
                colors.pressedColor = Data.PressedColor;
                colors.disabledColor = Data.DisableColor;
                break;
        }

        // Set Toggle
        toggle.transition = transition;
        toggle.colors = colors;
        toggle.spriteState = spriteState;
        backgroundImage.sprite = sprite;
        checkmarkImage.sprite = checkmarkSprite;
    }
}