using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CameraController cameraCtrl = null;
    [SerializeField] private PlayerController playerCtrl = null;

    [SerializeField] private Transform[] movePoints = null;
    private int _currentPoint = 0;

    public void StartGame()
    {
        cameraCtrl.SwitchCamera(true);
        NextPoint();
    }

    private void NextPoint()
    {
        if (_currentPoint < movePoints.Length)
        {
            playerCtrl.MoveToPoint(movePoints[_currentPoint].position);
            _currentPoint++;
        }
    }
}
