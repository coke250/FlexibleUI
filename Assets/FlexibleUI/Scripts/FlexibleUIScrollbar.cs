using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Scrollbar))]
[RequireComponent(typeof(Image))]
public class FlexibleUIScrollbar : FlexibleUI
{
    public enum ScrollbarType { Default }

    public FlexibleUIScrollbarData Data;
    public ScrollbarType Type;

    private Image backgroundImage;
    private Image handleImage;
    private Scrollbar scrollbar;

    public override void Awake()
    {
        scrollbar = GetComponent<Scrollbar>();
        backgroundImage = GetComponent<Image>(  );
        handleImage = scrollbar.handleRect.GetComponent<Image>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Selectable.Transition transition = Selectable.Transition.SpriteSwap;
        Sprite backgroundSprite = Data.BackgroundSprite;
        Sprite handleSprite = Data.DefaultHandleSprite;
        SpriteState spriteState = Data.DefaultHandleSpriteState;
        ColorBlock colors = new ColorBlock();

        colors.colorMultiplier = 1;
        colors.fadeDuration = 0.1f;

        switch (Type)
        {
            case ScrollbarType.Default:
                transition = Selectable.Transition.ColorTint;

                colors.normalColor = Data.NormalColor;
                colors.highlightedColor= Data.HighlightedColor;
                colors.pressedColor= Data.PressedColor;
                colors.disabledColor = Data.DisableColor;

                break;
        }

        // Set Scrollbar
        scrollbar.transition = transition;
        scrollbar.colors = colors;
        scrollbar.spriteState = spriteState;
        backgroundImage.sprite = backgroundSprite;
        handleImage.sprite = handleSprite;
    }
}
