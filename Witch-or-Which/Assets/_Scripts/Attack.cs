using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour{
    
    void OnTriggerEnter(Collider coll){
        GameObject collidedWith = coll.gameObject;
        //Component entityScript = TryGetComponent<Entity>();
        Debug.Log("Hit something");
        if(collidedWith.TryGetComponent(out Entity entityScript)){
            Debug.Log("Dealt Damage To: " + collidedWith);
        }else{
            Debug.Log("Did Not Do Damage");
        }
    }
}
