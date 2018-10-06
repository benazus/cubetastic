using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public LevelManager levelManager;

    public void OnTriggerEnter(Collider other) {
        levelManager.CompleteLevel();
    }
}
