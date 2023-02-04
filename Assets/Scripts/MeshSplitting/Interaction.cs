using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JL.Splitting;
using Debug = UnityEngine.Debug;

public class Interaction : MonoBehaviour
{
    [SerializeField] private bool _splitAsync = true;
    [SerializeField] private float _cutRange = 10f;
    [SerializeField] private GameObject _player = null;
    [SerializeField] private Transform _planeTransform = null;

    private void Update()
    {
        //Vector3 playerPosition = _player.transform.position;
        //Vector3 playerDirection = _player.transform.forward;

        //RaycastHit hit;
        //if (Physics.Raycast(playerPosition, playerDirection.normalized, out hit, _cutRange))
        //{
        //    Debug.DrawRay(playerPosition, playerDirection * _cutRange, Color.red);
        //}
        //else
        //{
        //    Debug.DrawRay(playerPosition, playerDirection * _cutRange, Color.green);
        //}
    }



    public void TrySplitObject()
    {
        RaycastHit hit;
        Vector3 playerPosition = _player.transform.position;
        Vector3 playerDirection = _player.transform.forward;
        if (Physics.Raycast(playerPosition, playerDirection.normalized, out hit, _cutRange))
        {
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
