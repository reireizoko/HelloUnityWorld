using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector2 minRange = new Vector2(-5f, -5f);
    public Vector2 maxRange = new Vector2(5f, 5f);

    private void Update()
    {
        // Quit on Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // So it works in the editor
#endif
        }

        // Teleport on any key
        if (Input.anyKeyDown)
        {
            float x = Random.Range(minRange.x, maxRange.x);
            float y = Random.Range(minRange.y, maxRange.y);
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}
