using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePit : MonoBehaviour
{
    [SerializeField] private float _fuleDrain = 1f;
    [SerializeField] private GameObject _flames = null;
    private Light _light = null;
    [SerializeField] private float _fuelLevel = 10f;
    private float _fuelToFill = 0f;
    private float _fillSpeed = 3f;

    void Start()
    {
        _light = _flames.transform.GetChild(1).GetComponent<Light>();
    }

    void Update()
    {
        updateFuel();
        updateFire();
    }

    private void updateFuel()
    {
        if (_fuelToFill >= _fillSpeed)
        {
            _fuelLevel += _fillSpeed * Time.deltaTime;
            _fuelToFill -= _fillSpeed * Time.deltaTime;
        }
        _fuelLevel -= _fuleDrain * Time.deltaTime;
    }

    private void updateFire()
    {
        _flames.transform.localScale = new Vector3(_fuelLevel * 2, _fuelLevel * 2, _fuelLevel * 2);
        _light.range = _fuelLevel * 10;

        // TODO: Flicker

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Root")
        {
            _fuelToFill += collision.rigidbody.mass;
            Destroy(collision.gameObject);
        }
    }
}
