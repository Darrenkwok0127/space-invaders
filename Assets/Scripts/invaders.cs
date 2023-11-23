using UnityEngine;

public class invaders : MonoBehaviour
{
    public int rows = 4;
    public int cols = 4;
    public invader[] prefabs;

    private void Awake()
    {
        for (int row = 0; row < rows; row++)
        {
            float positionY = row * 1.5f;
            for (int col = 0; col < cols; col++)
            {
                float positionX = col * 1.5f;
                Vector3 position = new Vector3(positionX, positionY);
                invader invader = Instantiate(prefabs[0+row], this.transform);
                invader.transform.position = position;
                
            }
           
        }
        float X = cols * 1.5f / 2;
        this.transform.position = new Vector3(- X + 0.75f, this.transform.position.y);
    }
}
