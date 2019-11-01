using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class FlexibleUIButton : FlexibleUI
{
    public enum ButtonType { Default }

    public FlexibleUIButtonData Data;
    public ButtonType Type;

    private Image image;
    private Image iconImage;
    private Text text;
    private Button button;

    public override void Awake()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        iconImage = transform.Find("Icon").GetComponent<Image>();
        text = GetComponentInChildren<Text>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Selectable.Transition transition = Selectable.Transition.SpriteSwap;
        Sprite sprite = Data.DefaultSprite;
        Sprite iconSprite = Data.DefaultIconSprite;
        SpriteState spriteState = Data.DefaultSpriteState;
        ColorBlock colors = new ColorBlock();

        colors.colorMultiplier = 1;
        colors.fadeDuration = 0.1f;

        int fontSize = Data.FontSize;
        Font font = Data.Font;
        Color fontColor = Data.FontColor; ;

        switch (Type)
        {
            case ButtonType.Default:
                
                transition = Selectable.Transition.ColorTint;
                
                colors.normalColor = Data.NormalColor;
                colors.highlightedColor = Data.HighlightedColor;
                colors.pressedColor = Data.PressedColor;
                colors.disabledColor = Data.DisableColor;
                break;
        }

        // Set Button
        button.transition = transition;
        button.colors = colors;
        button.spriteState = spriteState;
        image.sprite = sprite;
        iconImage.sprite = iconSprite;

        text.fontSize = fontSize;
        text.font = font;
        text.color = fontColor;
    }
}
