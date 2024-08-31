using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeView : MonoBehaviour, ICubeView
{
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TMP_InputField valueInput;
    [SerializeField] private TMP_InputField scoreInput;
    [SerializeField] private TMP_InputField damageInput;
    [SerializeField] private Button updateValueButton;
    [SerializeField] private Button addScoreButton;
    [SerializeField] private Button takeDamageButton;
    
    public int Value
    {
        get => int.Parse(valueText.text);
        set => valueText.text = "Value: " + value.ToString();
    }

    public int Score
    {
        get => int.Parse(scoreText.text);
        set => scoreText.text = "Score: " + value.ToString();
    }

    public int Health
    {
        get => int.Parse(healthText.text);
        set => healthText.text = "Health: " + value.ToString();
    }

    public void RegisterUpdateValueButtonClickListener(Action<int> onClick)
    {
        updateValueButton.onClick.AddListener(() => {
            if (int.TryParse(valueInput.text, out int value))
            {
                onClick?.Invoke(value);
            }
        });
    }

    public void RegisterAddScoreButtonClickListener(Action<int> onClick)
    {
        addScoreButton.onClick.AddListener(() => {
            if (int.TryParse(scoreInput.text, out int score))
            {
                onClick?.Invoke(score);
            }
        });
    }

    public void RegisterTakeDamageButtonClickListener(Action<int> onClick)
    {
        takeDamageButton.onClick.AddListener(() => {
            if (int.TryParse(damageInput.text, out int damage))
            {
                onClick?.Invoke(damage);
            }
        });
    }
}
