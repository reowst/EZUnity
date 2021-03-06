/* Author:          ezhex1991@outlook.com
 * CreateTime:      2019-08-20 13:23:31
 * Organization:    #ORGANIZATION#
 * Description:     
 */
using EZhex1991.EZUnity;
using UnityEngine;

namespace EZhex1991.EZTextureProcessor
{
    [CreateAssetMenu(fileName = "EZTexturePipeline",
        menuName = EZTextureProcessorUtility.MenuName_TextureProcessor + "EZTexturePipeline",
        order = (int)EZAssetMenuOrder.EZTexturePipeline)]
    public class EZTexturePipeline : EZTextureGenerator
    {
        public EZTextureGenerator[] textureProcessors;

        public override bool previewAutoUpdate { get { return false; } }

        public override void SetTexturePixels(Texture2D texture)
        {
            for (int i = 0; i < textureProcessors.Length; i++)
            {
                if (textureProcessors[i] == null) continue;
                textureProcessors[i].SetTexturePixels(texture);
            }
        }
    }
}
