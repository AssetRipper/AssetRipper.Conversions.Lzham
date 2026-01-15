using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update@adaptive_bit_model@lzham@@QEAAXI@Z")]
[DemangledName("public: void __cdecl lzham::adaptive_bit_model::update(unsigned int)")]
[CleanName("update")]
internal static partial class update_yyeigq
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int bit)
	{
		unchecked
		{
			if (bit == 0)
			{
				int num = 2048 - (ushort)((lzham_adaptive_bit_model*)@this)->m_bit_0_prob >>> 5;
				short* bit_0_prob = &((lzham_adaptive_bit_model*)@this)->m_bit_0_prob;
				*bit_0_prob = (short)((ushort)(*bit_0_prob) + num);
			}
			else
			{
				int num2 = (ushort)((lzham_adaptive_bit_model*)@this)->m_bit_0_prob >> 5;
				short* bit_0_prob2 = &((lzham_adaptive_bit_model*)@this)->m_bit_0_prob;
				*bit_0_prob2 = (short)checked(unchecked((ushort)(*bit_0_prob2)) - num2);
			}
		}
	}
}
