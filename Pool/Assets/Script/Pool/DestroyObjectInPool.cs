using UnityEngine;
using System.Collections;

public class DestroyObjectInPool : MonoBehaviour
{

	void OnEnable()
	{
		Invoke("Destroy", 2.0f);
	}

	void Destroy()
	{
		gameObject.SetActive(false);
	}

	void OnDisable()
	{
		CancelInvoke();
	}

    public float speed = 5.0f;

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
    }

}