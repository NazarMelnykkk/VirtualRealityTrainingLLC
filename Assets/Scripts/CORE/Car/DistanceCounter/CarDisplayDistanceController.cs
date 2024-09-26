using TMPro;
using UnityEngine;

public class CarDisplayDistanceController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _distanceText;

    private string _distanceString = "Nearest car - ";

    public void UpdateDistanceText(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            _distanceText.SetText("");
            return;
        }

        _distanceText.SetText(_distanceString + text);
    }
}
