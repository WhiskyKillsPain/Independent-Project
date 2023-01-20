using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    
    GameManager _gameManager;
    
    private void OnTriggerEnter2D(Collider2D other) 
     {
            if(other.gameObject.CompareTag("Player"))
            {
                _gameManager.UpdateKeyCount(_value);
            }
     }
    }

