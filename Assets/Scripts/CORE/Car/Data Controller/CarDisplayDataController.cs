using TMPro;
using UnityEngine;

public class CarDisplayDataController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dataText;

    public void UpdateDisplayDataText(float vehicleSpeed , float clutchRpm, float gearNumber)
    {
        _dataText.SetText($"Speed: {vehicleSpeed:F0}\nRPM: {clutchRpm:F0}\nGear: {gearNumber:F0}");
    }
}
