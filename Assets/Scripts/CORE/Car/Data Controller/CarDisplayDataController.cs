using TMPro;
using UnityEngine;

public class CarDisplayDataController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dataText;

    public void UpdateDisplayDataText(float vehicleSpeed, float clutchRpm, int gearNumber, TransmissionOperatingMode transmissionMode, bool engineWorking)
    {
        _dataText.SetText(
            $"Speed: {vehicleSpeed:F0} km/h\n" +
            $"RPM: {clutchRpm:F0}\n" +
            $"Gear: {gearNumber}\n" +
            $"Transmission Mode: {transmissionMode}\n" +
            $"Engine Status: {(engineWorking ? "On" : "Off")}"
        );
    }
}
