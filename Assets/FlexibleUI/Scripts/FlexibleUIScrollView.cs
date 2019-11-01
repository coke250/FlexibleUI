using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
public class FlexibleUIScrollView : FlexibleUI
{
    public enum ScrollViewType { Default}

    public FlexibleUIScrollViewData Data;
    public ScrollViewType Type;
    
    private Image backgroundImage;
    private Image uiMaskImage;

    public override void Awake()
    {
        backgroundImage = GetComponent<Image>();
        uiMaskImage = GetComponent<ScrollRect>().viewport.GetComponent<Image>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Sprite backgroundSprite = Data.BackgroundSprite;
        Color backgroundColor = Data.BackgroundColor;
        Sprite uiMaskSprite = Data.UIMaskSprite;
        Color uiMaskColor = Data.UIMaskColor;

        switch (Type)
        {
            case ScrollViewType.Default:
                break;
        }

        // Set Scroll View Image
        backgroundImage.sprite = backgroundSprite;
        backgroundImage.color = backgroundColor;
        uiMaskImage.sprite = uiMaskSprite;
        uiMaskImage.color = uiMaskColor;
    }
}
