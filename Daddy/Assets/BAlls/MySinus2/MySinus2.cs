using UnityEngine;

public class MySinus2 : MonoBehaviour
{
    [SerializeField] private GameObject Ref;
    [SerializeField] private GameObject Exp;
    float t = 0f;
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private float Amplitude = 1f;
    [SerializeField] private float Offset;
    [SerializeField] private float AngularFrequency;


    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = Ref.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Ref.transform.position = new Vector3(t, Mathf.Sin(t), 0);
        Exp.transform.position = new Vector3(t, y(), 0);
        t += Time.deltaTime;
        if (t > 10f)
        {
            t = -8f;
            trailRenderer.enabled = false;
        }
        else { trailRenderer.enabled = true; }
    }

    private float y()
    {
        float y = Offset + Amplitude * Mathf.Sin(t * AngularFrequency);
        float x = Mathf.Cos(t);
        return y;
    }
}
