// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/CRTShader"
{
	Properties{
		_MainTex("Base (RGB)", 2D) = "white" {}
		_vertsColor("Verts fill color", float) = 0
		_vertsColor2("Verts fill color2", float) = 0
		_contrast("Contrast", float) = 0
		_br("Brightness", float) = 0
		_scansColor("ScanColor", float) = 0
	}

		SubShader{
			Pass {
				ZTest Always Cull Off ZWrite Off Fog { Mode off }

				CGPROGRAM

				#pragma vertex vert
				#pragma fragment frag
				#pragma fragmentoption ARB_precision_hint_fastest
				#include "UnityCG.cginc"
				#pragma target 3.0

				struct v2f
				{
					float4 pos      : POSITION;
					float2 uv       : TEXCOORD0;
					float4 scr_pos	: TEXCOORD1;
				};

				uniform sampler2D _MainTex;
				uniform float _vertsColor;
				uniform float _vertsColor2;
				uniform float _contrast;
				uniform float _br;
				uniform float _scansColor;

				v2f vert(appdata_img v)
				{
					v2f o;
					o.pos = UnityObjectToClipPos(v.vertex);
					o.uv = MultiplyUV(UNITY_MATRIX_TEXTURE0, v.texcoord);
					o.scr_pos = ComputeScreenPos(o.pos);
					return o;
				}

				half4 frag(v2f i) : COLOR
				{
					float2 ps = i.scr_pos.xy * _ScreenParams.xy / i.scr_pos.w;
					half4 color = tex2D(_MainTex, i.uv);

					int pp = (int)ps.x % 3;
					float4 muls = float4(0, 0, 0, 1);
					if (pp == 1) {
						muls.r = color.r;
						muls.g = _vertsColor2;
					}
					else if (pp == 2) {
						muls.g = color.g;
						muls.b = _vertsColor2;
					}
					else {
						muls.b = color.b;
						muls.r = _vertsColor2;
					}
					if ((int)ps.y % 3 == 0) muls *= float4(_scansColor, _scansColor, _scansColor, 1);

					color += (_br / 255);
					color = color - _contrast * (color - 1.0) * color * (color - 0.5);

					color = color * muls;

					return color;
				}

				ENDCG
			}
	}
		FallBack "Diffuse"
}
