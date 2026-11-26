using UnityEngine;

public class Skin : MonoBehaviour
{
    public GameObject player;
    public GameObject showSkin;

    public Color[] colors = {Color.black, Color.blue, Color.cyan, Color.green, Color.grey, Color.magenta, Color.red, Color.white, Color.yellow};

    public void SetColorByIndex(int index)
    {
        if (index < 0 || index >= colors.Length) return;

        ApplyToTargets(colors[index]);
    }

    private void ApplyToTargets(Color color)
    {
        ApplyToObject(player, color);
        ApplyToObject(showSkin, color);
    }

    private void ApplyToObject(GameObject target, Color color)
    {
        if (target == null) return;

        foreach (SpriteRenderer sr in target.GetComponentsInChildren<SpriteRenderer>())
        {
            sr.color = color;
        }
    }
}