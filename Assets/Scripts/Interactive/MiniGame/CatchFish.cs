using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFish : MonoBehaviour
{
    // 引用预制件。在 Inspector 中，将预制件拖动到该字段中。
    public GameObject obstacle;
    TimerMgr timer;
    int TimerID;
    public Transform CameraController;
    public bool isRotate;

    void Start()
    {
        //初始化
        timer = new TimerMgr();
        timer.Init();
        //启动定时器
        TimerID = timer.Schedule(FishLaunch, 0, 2);
    }

    void Update()
    {
        timer.Update();
        if(isRotate)
        CameraRotateRight();
        if(!isRotate)
        CameraRotateLeft();
    }
    
    private void FishLaunch()
    {
        // 实例化为位置 (0, 0, 0) 和零旋转。
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
    public void Rotateleft()
    {
        isRotate = true;
    }
    public void Rotateright()
    {
        isRotate = false;
    }
    public void CameraRotateRight()
    {
        Vector3 dir = new Vector3(1,0,0);
        Quaternion targetQua = Quaternion.LookRotation(dir);
        CameraController.rotation = Quaternion.Slerp(CameraController.rotation,targetQua,2 * Time.deltaTime);
    }
    public void CameraRotateLeft()
    {
        Vector3 dir = new Vector3(0,0,1);
        Quaternion targetQua = Quaternion.LookRotation(dir);
        CameraController.rotation = Quaternion.Slerp(CameraController.rotation,targetQua,2 * Time.deltaTime);
    }
}