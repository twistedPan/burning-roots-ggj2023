using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JL.Splitting;
using Debug = UnityEngine.Debug;

public class Interaction : MonoBehaviour
{
    [SerializeField] private GameValues gameValues;
    [SerializeField] private bool _splitAsync = true;
    private Transform _planeTransform = null;
    private GameObject _player = null;
    private float _cutRange = 1f;

    private void Start()
    {
        _player = gameObject;
        _planeTransform = transform.Find("Blade");
        _cutRange = gameValues.PlayerCutRange;
    }

    private void Update()
    {
        Vector3 playerPosition = _planeTransform.position;
        Vector3 playerDirection = _player.transform.forward;

        if (Physics.Raycast(playerPosition, playerDirection.normalized, out _, _cutRange))
        {
            Debug.DrawRay(playerPosition, playerDirection * _cutRange, Color.red);
        }
        else
        {
            Debug.DrawRay(playerPosition, playerDirection * _cutRange, Color.green);
        }
    }



    public void TrySplitObject()
    {
        _cutRange = gameValues.PlayerCutRange;
        RaycastHit hit;
        Vector3 playerDirection = _player.transform.forward;
        if (Physics.Raycast(_planeTransform.position, playerDirection.normalized, out hit, _cutRange))
        {
            Debug.Log("Ray Hit: " + hit.transform.name);
            SplittableBase splittable = hit.transform.GetComponentInParent<SplittableBase>();
            if (splittable != null)
            {
                SplitObject(splittable);
            }
        }
    }

    private void SplitObject(SplittableBase splittable)
    {
        PointPlane plane = new PointPlane(_planeTransform.position, _planeTransform.rotation);
        if (_splitAsync)
        {
            splittable.SplitAsync(plane, null);
        }
        else
        {
            splittable.Split(plane);
        }
    }
}
