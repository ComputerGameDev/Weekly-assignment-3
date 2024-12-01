using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardSpawner : MonoBehaviour
{
    [SerializeField] InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject bullets; // Class-level field
    [SerializeField] protected Vector3 velocityOfbullet;

    protected virtual GameObject spawnObject()
    {
        Vector3 positionOfbullet = transform.position;
        Quaternion rotationOfbullet = Quaternion.identity;

        // Use the class-level 'bullets' field
        GameObject bulletInstance = Instantiate(bullets, positionOfbullet, rotationOfbullet);

        Mover bulletMover = bulletInstance.GetComponent<Mover>();
        if (bulletMover)
        {
            bulletMover.SetVelocity(velocityOfbullet);
        }
        return bulletInstance;
    }

    void OnEnable()
    {
        spawnAction.Enable();
    }

    void OnDisable()
    {
        spawnAction.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.WasPressedThisFrame())
        {
            spawnObject();
        }
    }
}
