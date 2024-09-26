using UnityEngine;
using VehiclePhysics;

public enum TransmissionOperatingMode
{
    Automatic = 0,
    Manual = 1,
    SemiAutomatic = 2,
}

public class VehicleDataProvider : MonoBehaviour
{
    public static VehicleDataProvider Instance { get; private set; }

    [SerializeField] private VPVehicleController _vehicleController;
    [SerializeField] private CarDisplayDataController _carDisplayDataController;

    public float VehicleSpeed => _vehicleController.speed;
    public float TransmissionRpm => _vehicleController.data.Get(Channel.Vehicle, VehicleData.TransmissionRpm);
    public bool IsGearboxShifting => _vehicleController.data.Get(Channel.Vehicle, VehicleData.GearboxShifting) != 0;
    public int GearNumber => _vehicleController.data.Get(Channel.Vehicle, VehicleData.GearboxGear);

    public TransmissionOperatingMode TransmissionOperatingMode
    {
        get
        {
            int mode = _vehicleController.data.Get(Channel.Settings, SettingsData.AutoShiftOverride);
            switch (mode)
            {
                case 0:
                    return TransmissionOperatingMode.Automatic;
                case 1:
                    return TransmissionOperatingMode.Manual;
                case 2:
                    return TransmissionOperatingMode.SemiAutomatic;
                default:
                    return TransmissionOperatingMode.Automatic;
            }
        }
    }

    public bool EngineWorking
    {
        get
        {
            return _vehicleController.data.Get(Channel.Vehicle, VehicleData.EngineWorking) != 0;
        }
    }

    public float ClutchRpm
    {
        get
        {
            if (!IsGearboxShifting && GearNumber > 0)
            {
                float gearRatio = _vehicleController.gearbox.forwardGearRatios[GearNumber - 1];
                return TransmissionRpm * gearRatio / 1000;
            }
            return 0f;
        }
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }    
    }

    private void FixedUpdate()
    {
        _carDisplayDataController.UpdateDisplayDataText(
            VehicleSpeed,
            ClutchRpm,
            GearNumber,
            TransmissionOperatingMode,
            EngineWorking
        );
    }
}

