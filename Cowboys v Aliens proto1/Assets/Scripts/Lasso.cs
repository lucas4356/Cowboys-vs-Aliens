using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasso : MonoBehaviour
{
    [SerializeField] float lassoSpeed;
    [SerializeField] float lassoDistance;

    private Rigidbody rb;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * lassoSpeed;
        startPosition = transform.position;         
    }

    void Update()
    {
      if (Vector3.Distance(startPosition, transform.position) >= lassoDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.isTrigger)
        {
            return;
        }

        IGetLassoed gotLassoed = other.gameObject.GetComponent<IGetLassoed>();
        if (gotLassoed != null)
        {
            gotLassoed.GetLassoed();
            Destroy(gameObject);
        }
    }

    


}