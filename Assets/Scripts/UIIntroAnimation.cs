using UnityEngine;

public class UIIntroAnimation : MonoBehaviour
{
    [Header("UI References")]
    public RectTransform panel;
    public RectTransform button1;
    public RectTransform button2;

    [Header("Animation Settings")]
    public Vector2 panelStartPos = new Vector2(0, -800);
    public Vector2 panelEndPos = new Vector2(0, 0);

    public Vector2 button1StartPos = new Vector2(-800, 0);
    public Vector2 button1EndPos = new Vector2(-200, 0);

    public Vector2 button2StartPos = new Vector2(800, 0);
    public Vector2 button2EndPos = new Vector2(200, 0);

    public float duration = 1f;
    public float delayBetween = 0.3f;
    public LeanTweenType easeType = LeanTweenType.easeOutExpo;

    void Start()
    {
        panel.anchoredPosition = panelStartPos;
        button1.anchoredPosition = button1StartPos;
        button2.anchoredPosition = button2StartPos;

        LeanTween.move(panel, panelEndPos, duration).setEase(easeType);

        LeanTween.move(button1, button1EndPos, duration)
            .setEase(easeType)
            .setDelay(delayBetween);

        LeanTween.move(button2, button2EndPos, duration)
            .setEase(easeType)
            .setDelay(delayBetween * 2);
    }
}
