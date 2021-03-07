using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent _playerNavMesh;
    private Animator _animator;

    private void Start()
    {
        _playerNavMesh = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", _playerNavMesh.velocity.magnitude);
    }

    public void MoveToPoint(Vector3 point)
    {
        _playerNavMesh.SetDestination(point);
    }
}
