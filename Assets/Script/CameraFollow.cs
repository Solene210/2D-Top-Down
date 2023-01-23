using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Expose

    [SerializeField]
    private Transform _target;
    [SerializeField]
    [Range(0f, 15f)]
    private float _lerpTime;
    #endregion

    #region Unity Lyfecycle
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, _target.position, _lerpTime * Time.deltaTime);
        newPosition.z = -10;
        transform.position = newPosition;
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected

    #endregion
}
