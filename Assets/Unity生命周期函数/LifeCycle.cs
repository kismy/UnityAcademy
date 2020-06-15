using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {

    private void Reset()
    {
        Debug.Log("Reset");
    }
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    void Start () {
        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate | 物理循环帧");
    }
    void Update () {
        Debug.Log("Update | GameLogic帧");
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    private void OnPreCull()
    {
        Debug.Log("OnPreCull");

    }
    private void OnPostRender()
    {
        Debug.Log("OnPostRender");

    }
    private void OnRenderObject()
    {
        Debug.Log("OnRenderObject");

    }
    private void OnGUI()
    {
        Debug.Log("OnGUI");

    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");

    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");

    }
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("OnApplicationPause:"+ pause);
    }
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
}
