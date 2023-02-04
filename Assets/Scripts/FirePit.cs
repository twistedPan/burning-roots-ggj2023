using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePit : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    [SerializeField] private GameObject _flames = null;
    [SerializeField] private float _currentFuelLevel = 0f;
    private Light _light = null;
    private float _fuelToFill = 0f;
    private float _tmp_fuelIntake = 0f;

    void Start()
    {
        _light = _flames.transform.GetChild(1).GetComponent<Light>();
        _currentFuelLevel = gameValues.FireFuelStartAmount;
    }

    void Update()
    {
        updateFuel();
        updateFire();
    }

    private void updateFuel()
    {
        _tmp_fuelIntake = gameValues.FuelFillSpeed * Time.deltaTime;
        if (_fuelToFill >= _tmp_fuelIntake)
        {
            _currentFuelLevel += _tmp_fuelIntake;
            _fuelToFill -= _tmp_fuelIntake;
        }
        _currentFuelLevel -= gameValues.FireFuelDrain * Time.deltaTime;
        // TODO: Drain -> linear abflachend gegen 0
    }

    private void updateFire()
    {
        _flames.transform.localScale = new Vector3(_currentFuelLevel, _currentFuelLevel, _currentFuelLevel);
        _light.range = _currentFuelLevel * gameValues.FireLightRangeFactor;
        _light.intensity = _currentFuelLevel * gameValues.FireLightIntensityFactor;

        // TODO: Flicker

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Root"))
        {
            _fuelToFill += collision.rigidbody.mass;
            Destroy(collision.gameObject);
        }
    }
}
