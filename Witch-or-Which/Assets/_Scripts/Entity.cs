using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour{
    public string nameValue;
    public int levelValue;
    public float experienceValue;
    public float healthValue;
    public float attackValue;
    public float shieldValue;

    public int checkAlive(){
        if(healthValue <= 0){
            Destroy(this.gameObject);
            Debug.Log("Destroyed " + nameValue);
            return -1;
        }else{
            Debug.Log("Entity still alive: " + nameValue);
            return 1;
        }
    }
}
