using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplePatrol : MonoBehaviour
{
  [SerializeField]
  bool _patrolWaiting;

  [SerializeField]
  float _totalWaitTime = 3f;

  [SerializeField]
  List<Waypoint> _patrolPoints;

  float _switchProbability = 0.2f;

  UnityEngine.AI.NavMeshAgent _navMeshAgent;
  int _currentPatrolIndex;
  bool _traveling;
  bool _waiting;
  bool _patrolForward;
  float _waitTimer;

  public void Start(){
    _navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

    if(_navMeshAgent == null) {
      Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
    }
    else {
      if(_patrolPoints != null && _patrolPoints.Count >= 2) {
        _currentPatrolIndex = 0;
        SetDestination();
      }
      else {
        Debug.Log("Insufficent patrol points for basic patrolling behaviour.");
      }
    }
  }

  public void Update() {
    if(_traveling && _navMeshAgent.remainingDistance <= 1.0f) {
      _traveling = false;

      if(_patrolWaiting){
        _waiting = true;
        _waitTimer = 0f;
      }
      else {
        ChangePatrolPoint();
        SetDestination();
      }
    }

    if(_waiting) {
      _waitTimer += Time.deltaTime;
      if(_waitTimer >= _totalWaitTime){
        _waiting = false;

        ChangePatrolPoint();
        SetDestination();
      }
    }
  }

  private void SetDestination() {
    if(_patrolPoints != null){
      Vector3 targetVector = _patrolPoints[_currentPatrolIndex].transform.position;
      _navMeshAgent.SetDestination(targetVector);
      _traveling = true;
    }
  }

  private void ChangePatrolPoint(){
    if(UnityEngine.Random.Range(0f, 1f) <= _switchProbability){
      _patrolForward = !_patrolForward;
    }

    if(_patrolForward){
      _currentPatrolIndex = (_currentPatrolIndex + 1) % _patrolPoints.Count;
    }
    else {
      if(--_currentPatrolIndex < 0){
        _currentPatrolIndex = _patrolPoints.Count - 1;
      }
    }
  }

}
