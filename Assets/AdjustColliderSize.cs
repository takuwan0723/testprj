using UnityEngine;

public class AdjustColliderSize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        // スプライトのBoundsを取得
        Bounds spriteBounds = spriteRenderer.bounds;

        // 一時変数にBounds.sizeをコピー
        Vector3 scaledSize = spriteBounds.size;

        // TransformでlocalScaleされていた場合を考慮
        // Transformでのサイズ変更は極力行い方針にしたため、コメントアウト
        //if(transform.localScale != Vector3.one)
        //{
        //    scaledSize = transform.localScale;
        //}

        // Boundsをコライダーのサイズに設定
        collider.size = scaledSize;
    }
}
