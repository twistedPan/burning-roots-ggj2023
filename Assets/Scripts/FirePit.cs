using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirePit : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    [SerializeField] private GameObject _flames = null;
    [SerializeField] private float _currentFuelLevel = 0f;
    [SerializeField] private GameObject frost;
    [SerializeField] private GameObject UIElem;
    [SerializeField] private GameObject particleGameObject;
    private DynamicCamera _camera;
    private ParticleSystem fireParticleSystem;
    private RectTransform frostImg;
    private Light _light = null;
    private float _fuelToFill = 0f;
    private float _tmp_fuelIntake = 0f;
    [SerializeField] private bool isMenuFire = false;
    private bool _waitWithStarting = true;
    private float _startWaitTime;

    void Start()
    {
        _light = _flames.transform.GetChild(1).GetComponent<Light>();
        _currentFuelLevel = gameValues.FireFuelStartAmount;
        fireParticleSystem = particleGameObject.GetComponent<ParticleSystem>();
        _camera = FindObjectOfType<DynamicCamera>();

        _startWaitTime = gameValues.FireBurnDownStartDelay;

        Debug.Log(frost);
        frostImg = frost.GetComponent<RectTransform>();
        Debug.Log(frostImg);

        updateFuel();
        updateFire();
    }

    void Update()
    {
        if (isMenuFire) return;

        if (_waitWithStarting)
        {
            _startWaitTime -= Time.deltaTime;
            if (_startWaitTime < 0)
            {
                _waitWithStarting = false;
                fireParticleSystem.Play();
                fireParticleSystem.Play();
            }
            return;
        }

        updateFuel();
        updateFire();
    }

    private void updateFuel()
    {
        _tmp_fuelIntake = gameValues.FireNewFuelIntakeSpeed * Time.deltaTime;
        if (_fuelToFill >= _tmp_fuelIntake)
        {
            _currentFuelLevel += _tmp_fuelIntake;
            _fuelToFill -= _tmp_fuelIntake;
        }

        float approxFuelDrainSpeed = gameValues.FireFuelBurnCurve.Evaluate(D_Utilities.MapRange(_currentFuelLevel, 0, gameValues.FireMaxFuelLevel, .1f, 1)) * gameValues.FireFuelMaxDrainSpeed;
        _currentFuelLevel -= approxFuelDrainSpeed * Time.deltaTime;

        if (gameValues.PrintCurrentFuelLevel) Debug.Log("Current Level: " + _currentFuelLevel + "\nCurrent Drain Speed: " + approxFuelDrainSpeed + "\n Position on Curve: " + gameValues.FireFuelBurnCurve.Evaluate(D_Utilities.MapRange(_currentFuelLevel, 0, gameValues.FireMaxFuelLevel, .1f, 1)));
        if (_currentFuelLevel > gameValues.FireMaxFuelLevel) _currentFuelLevel = gameValues.FireMaxFuelLevel;
        if (_currentFuelLevel < gameValues.FireMaxFuelLevel * 0.3)
        {
            float scale = D_Utilities.MapRange(_currentFuelLevel, 0, (float)(gameValues.FireMaxFuelLevel * 0.3), 1.5f, 3);
            frostImg.transform.localScale = new Vector3(scale, scale, 1);
        }

        if (_currentFuelLevel <= 0)
        {
            Time.timeScale = 0;
            UIElem.SetActive(true);

        }
    }

    private void updateFire()
    {
        _flames.transform.localScale = new Vector3(_currentFuelLevel, _currentFuelLevel, _currentFuelLevel) * gameValues.FireSizeFactor;
        _light.intensity = _currentFuelLevel * gameValues.FireLightIntensityFactor;

        // TODO: Flicker

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Root"))
        {
            _fuelToFill += (collision.rigidbody.mass / (_camera.PlayerAmount + 1));
            Destroy(collision.gameObject);
            fireParticleSystem.Play();
        }
    }
}
