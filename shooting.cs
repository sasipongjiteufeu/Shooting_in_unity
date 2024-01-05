using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject prefep;
    
    public float shooting_speed;
    public float shooting_delay;

    [SerializeField] private Transform bullet_position;


    public bool can_shoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            
            Instantiate(prefep,bullet_position.position,quaternion.identity);
        }
        
    }
}
