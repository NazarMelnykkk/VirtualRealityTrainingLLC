using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class NearestCarDistanceTracker : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Camera _camera;
    [SerializeField] private CarDisplayDistanceController _carDisplayDistanceController;
    [SerializeField] private SphereCollider _triggerCollider;

    [Header("Settings")]
    [SerializeField] private float _detectionRange = 20f;
    [SerializeField] private LayerMask _carLayer;
    [SerializeField] private LayerMask _ignoreLayer;

    private float _rayRange = 40f;
    private List<Transform> _carsInRange = new List<Transform>();
    private Transform _nearestCar = null;

    private void OnTriggerEnter(Collider other)
    {
        if (IsCar(other))
        {
            _carsInRange.Add(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsCar(other))
        {
            _carsInRange.Remove(other.transform);
        }
    }

    private void FixedUpdate()
    {
        FindNearestCar();
    }

    private bool IsCar(Collider collider)
    {
        return (1 << collider.gameObject.layer & _carLayer) != 0;
    }

    private void FindNearestCar()
    {
        if (_carsInRange.Count == 0)
        {
            return;
        }

        _nearestCar = null;
        float shortestDistance = Mathf.Infinity;

        foreach (Transform car in _carsInRange)
        {
            float distance = Vector3.Distance(transform.position, car.position);

            if (distance <= _detectionRange)
            {
                if (IsInFieldOfView(car) == true)
                {
                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        _nearestCar = car;
                    }
                }
            }
        }

        if (_nearestCar != null)
        {
            _carDisplayDistanceController.UpdateDistanceText(shortestDistance.ToString("F1") + " meters");
        }
        else
        {
            _carDisplayDistanceController.UpdateDistanceText(null);
        }
    }

    private bool IsInFieldOfView(Transform target)
    {
        Vector3 directionToTarget = target.position - _camera.transform.position;
        float angleToTarget = Vector3.Angle(_camera.transform.forward, directionToTarget);

        if (angleToTarget <= _camera.fieldOfView)
        {
            RaycastHit hit;

            if (Physics.Raycast(_camera.transform.position, directionToTarget.normalized, out hit, _rayRange , ~_ignoreLayer))
            {
                return hit.transform == target;
            }
        }

        return false;
    }
}
