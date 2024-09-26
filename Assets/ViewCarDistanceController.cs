using TMPro;
using UnityEngine;

public class ViewCarDistanceController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _distanceText;

    private string _distanceString = "Nearest car - ";

    public void SetDistanceValue(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            _distanceText.SetText("");
            return;
        }

        _distanceText.SetText(_distanceString + text);
    }
}
