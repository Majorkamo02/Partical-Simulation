using UnityEngine;

public class CameraSettings : MonoBehaviour
{

    public float wallThickness = 0.5f;
    void Start()
    {
        var cam = Camera.main;
        Vector2 bl = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        Vector2 tr = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane));

        // Left Wall
        CreateWall(new Vector2(bl.x - wallThickness * 0.5f, (bl.y + tr.y) / 2),
                   new Vector2(wallThickness, tr.y - bl.y + wallThickness));

        // Right Wall
        CreateWall(new Vector2(tr.x + wallThickness * 0.5f, (bl.y + tr.y) / 2),
                   new Vector2(wallThickness, tr.y - bl.y + wallThickness));

        // Bottom Wall
        CreateWall(new Vector2((bl.x + tr.x) / 2, bl.y - wallThickness * 0.5f),
                   new Vector2(tr.x - bl.x + wallThickness, wallThickness));

        // Top Wall
        CreateWall(new Vector2((bl.x + tr.x) / 2, tr.y + wallThickness * 0.5f),
                   new Vector2(tr.x - bl.x + wallThickness, wallThickness));
    }
    void CreateWall(Vector2 center, Vector2 size)
    {
        var go = new GameObject("Wall");
        go.transform.position = center;
        var bc = go.AddComponent<BoxCollider2D>();
        bc.size = size;
        bc.sharedMaterial = Resources.Load<PhysicsMaterial2D>("BouncyMat"); 
        bc.isTrigger = false;

    }
}
