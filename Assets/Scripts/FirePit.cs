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
        _tmp_fuelIntake = gameValues.FireFuelIntakeSpeed * Time.deltaTime;
        if (_fuelToFill >= _tmp_fuelIntake)
        {
            _currentFuelLevel += _tmp_fuelIntake;
            _fuelToFill -= _tmp_fuelIntake;
        }

        float approxFuelDrainSpeed = gameValues.FireFuelBurnCurve.Evaluate(D_Utilities.MapRange(_currentFuelLevel, 0, gameValues.FireMaxFuelLevel, .1f, 1)) * gameValues.FireFuelMaxDrainSpeed;
        _currentFuelLevel -= approxFuelDrainSpeed * Time.deltaTime;

        Debug.Log("approxFuelDrainSpeed: " + approxFuelDrainSpeed + " Evaluate: " + gameValues.FireFuelBurnCurve.Evaluate(D_Utilities.MapRange(_currentFuelLevel, 0, gameValues.FireMaxFuelLevel, .1f, 1)));
        if (_currentFuelLevel > gameValues.FireMaxFuelLevel) _currentFuelLevel = gameValues.FireMaxFuelLevel;
    }

    private void updateFire()
    {
        _flames.transform.localScale = new Vector3(_currentFuelLevel, _currentFuelLevel, _currentFuelLevel) * gameValues.FireSizeFactor;
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
