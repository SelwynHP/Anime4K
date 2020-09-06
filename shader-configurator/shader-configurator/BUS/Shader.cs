using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace shader_configurator
{
    public class Shader
    {
        public string shaderDirectory = @"~~/shaders/";
        public static Dictionary<ShaderEnum, string> shaders = new Dictionary<ShaderEnum, string>
        {
            { ShaderEnum.AutoDownscale, "Anime4K_Auto_Downscale_Pre_x4.glsl" },
            { ShaderEnum.ThinLinesFast, "Anime4K_ThinLines_Fast.glsl" },
            { ShaderEnum.ThinLinesVeryFast, "Anime4K_ThinLines_VeryFast.glsl" },
            { ShaderEnum.ThinLinesHQ, "Anime4K_ThinLines_HQ.glsl" },
            { ShaderEnum.DarkLinesFast, "Anime4K_DarkLines_Fast.glsl" },
            { ShaderEnum.DarkLinesVeryFast, "Anime4K_DarkLines_VeryFast.glsl" },
            { ShaderEnum.DarkLinesHQ, "Anime4K_DarkLines_HQ.glsl" },
            { ShaderEnum.DeblurOriginal, "Anime4K_Deblur_Original.glsl" },
            { ShaderEnum.DeblurMedium, "Anime4K_Deblur_CNN_M.glsl" },
            { ShaderEnum.DeblurLarge, "Anime4K_Deblur_CNN_L.glsl" },
            { ShaderEnum.DeblurDOG, "Anime4K_Deblur_DoG.glsl" },
            { ShaderEnum.DenoiseMean, "Anime4K_Denoise_Bilateral_Mean.glsl" },
            { ShaderEnum.DenoiseMedian, "Anime4K_Denoise_Bilateral_Median.glsl" },
            { ShaderEnum.DenoiseMode, "Anime4K_Denoise_Bilateral_Mode.glsl" },
            { ShaderEnum.ResamplingArtifactMedium, "Anime4K_RA_CNN_M.glsl" },
            { ShaderEnum.ResamplingArtifactLarge, "Anime4K_RA_CNN_L.glsl" },
            { ShaderEnum.ResamplingArtifactUltra, "Anime4K_RA_CNN_UL.glsl" },
            { ShaderEnum.ResamplingArtifactDOG, "Anime4K_RA_DoG.glsl" },
            { ShaderEnum.UpscaleDOG, "Anime4K_Upscale_DoG_x2.glsl" },
            { ShaderEnum.UpscaleDOGDeblur, "Anime4K_Upscale_DoG_x2_Deblur.glsl" },
            { ShaderEnum.UpscaleDTD, "Anime4K_Upscale_DTD_x2.glsl" },
            { ShaderEnum.UpscaleOriginal, "Anime4K_Upscale_Original_x2.glsl" },
            { ShaderEnum.UpscaleOriginalDeblur, "Anime4K_Upscale_Original_x2_Deblur_x2.glsl" },
            { ShaderEnum.UpscaleMedium, "Anime4K_Upscale_CNN_M_x2.glsl" },
            { ShaderEnum.UpscaleMediumDeblur, "Anime4K_Upscale_CNN_M_x2_Deblur.glsl" },
            { ShaderEnum.UpscaleMediumDenoise, "Anime4K_Upscale_CNN_M_x2_Denoise.glsl" },
            { ShaderEnum.UpscaleLarge, "Anime4K_Upscale_CNN_L_x2.glsl" },
            { ShaderEnum.UpscaleLargeDeblur, "Anime4K_Upscale_CNN_L_x2_Deblur.glsl" },
            { ShaderEnum.UpscaleLargeDenoise, "Anime4K_Upscale_CNN_L_x2_Denoise.glsl" },
            { ShaderEnum.UpscaleUltra, "Anime4K_Upscale_CNN_UL_x2.glsl" },
            { ShaderEnum.UpscaleUltraDeblur, "Anime4K_Upscale_CNN_UL_x2_Deblur.glsl" },
            { ShaderEnum.UpscaleUltraDenoise, "Anime4K_Upscale_CNN_UL_x2_Denoise.glsl" }
        };
        public string GetValue(ShaderEnum key)
        {
            return shaderDirectory + shaders[key];
        }
    }
}