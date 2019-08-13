/* Author:          ezhex1991@outlook.com
 * CreateTime:      2019-06-06 13:55:50
 * Organization:    #ORGANIZATION#
 * Description:     
 */
using UnityEngine;

namespace EZhex1991.EZUnity.AssetGenerator
{
    [CreateAssetMenu(fileName = "EZPerlinNoiseTextureGenerator", menuName = "EZUnity/EZPerlinNoiseTextureGenerator", order = (int)EZAssetMenuOrder.EZPerlinNoiseTextureGenerator)]
    public class EZPerlinNoiseTextureGenerator : EZTextureGenerator
    {
        [EZCurveRect(0, 0, 1, 1)]
        public AnimationCurve outputCurve = AnimationCurve.Linear(0, 0, 1, 1);

        public Vector2 density = new Vector2(5, 5);

        public override void ApplyToTexture(Texture2D texture)
        {
            for (int x = 0; x < texture.width; x++)
            {
                for (int y = 0; y < texture.height; y++)
                {
                    float coordX = (float)x / (texture.width - 1);
                    float coordY = (float)y / (texture.height - 1);
                    coordX = coordX * density.x;
                    coordY = coordY * density.y;
                    Color color = Color.white * outputCurve.Evaluate(Mathf.PerlinNoise(coordX, coordY));
                    texture.SetPixel(x, y, color);
                }
            }
        }
    }
}