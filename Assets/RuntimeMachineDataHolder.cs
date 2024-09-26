using UnityEngine;
using VehiclePhysics;

public class RuntimeMachineDataHolder : MonoBehaviour
{
    [SerializeField] private VPVehicleController _vehicleController;
    [SerializeField] private Engine _engine;

    public float vehicleSpeed { get => _vehicleController.speed;  }

    public void Update()
    {
        Debug.LogError(vehicleSpeed);
    }
}
