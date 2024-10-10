using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] private GameObject blendShapesMesh;
    [SerializeField] private string BlendShapeBlink;
    bool isBlinking;
    float blinkValue;
    SkinnedMeshRenderer skinnedMeshRenderer;

    void Start()
    {
        skinnedMeshRenderer = blendShapesMesh.GetComponent<SkinnedMeshRenderer>();
    }

    void FixedUpdate()
    {
        if (!isBlinking)
        {
            if (Random.value > .99f)
            {
                isBlinking = true;
                blinkValue = 0;
            }
        }
        else
        {
            blinkValue += 10f;
            float blendValue = blinkValue;
            if (blendValue > 100)
            {
                blendValue = 100 - (blendValue - 100);
            }
            if (blinkValue > 200)
            {
                isBlinking = false;
            }
            else
            {
                skinnedMeshRenderer.SetBlendShapeWeight(skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(BlendShapeBlink), blendValue);
            }
        }
    }

}
