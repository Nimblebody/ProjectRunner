using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] Transform _cam;
    public float _playerActionDistance;
    bool active = false;
    RaycastHit hit;
    void Update(){
        active = Physics.Raycast(_cam.position,_cam.TransformDirection(Vector3.forward), out hit, _playerActionDistance);

        if(Input.GetKeyDown(KeyCode.F) && active == true){
            
        }
    }
}
