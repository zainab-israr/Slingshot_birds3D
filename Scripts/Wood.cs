using UnityEngine;

public class Wood : MonoBehaviour
{
	public GameObject WoodShatter;
    public AudioSource WoodCollision;

    void OnCollisionEnter(Collision collision)
	{
        if (collision.collider.CompareTag("Bird"))
        {
            WoodCollision.Play();
        }
		if (collision.relativeVelocity.magnitude > 14.5f)
		{
            Destroy();
		}
	}

	private void Destroy()
	{
        GameObject shatter = Instantiate(WoodShatter, transform.position, Quaternion.identity);
        GameManager.Instance.AddScore(500, transform.position, Color.white);
        Destroy(shatter, 2);
        GameManager.Instance.WoodDestruction.Play();
		Destroy(gameObject);
	}
}