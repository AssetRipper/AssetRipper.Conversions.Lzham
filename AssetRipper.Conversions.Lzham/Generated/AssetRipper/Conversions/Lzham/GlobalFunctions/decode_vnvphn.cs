using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode@symbol_codec@lzham@@QEAAIAEAVadaptive_bit_model@2@_N@Z")]
[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode(class lzham::adaptive_bit_model &, bool)")]
[CleanName("decode")]
internal static partial class decode_vnvphn
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("class lzham::adaptive_bit_model &")] void* model, [NativeType("bool")] bool update_model)
	{
		sbyte b = (update_model ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			while ((uint)((lzham_symbol_codec*)@this)->m_arith_length < 16777216u)
			{
				int num = Get_bits.Invoke(@this, 8);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				((lzham_symbol_codec*)@this)->m_arith_value = (((lzham_symbol_codec*)@this)->m_arith_value << 8) | num;
				((lzham_symbol_codec*)@this)->m_arith_length <<= 8;
			}
			int num2 = (ushort)((lzham_adaptive_bit_model*)model)->m_bit_0_prob * (((lzham_symbol_codec*)@this)->m_arith_length >>> 11);
			int num3 = (((uint)((lzham_symbol_codec*)@this)->m_arith_value >= (uint)num2) ? 1 : 0);
			if (num3 == 0)
			{
				if ((b & 1) == 1)
				{
					int num4 = 2048 - (ushort)((lzham_adaptive_bit_model*)model)->m_bit_0_prob >>> 5;
					short* bit_0_prob = &((lzham_adaptive_bit_model*)model)->m_bit_0_prob;
					*bit_0_prob = (short)((ushort)(*bit_0_prob) + num4);
				}
				((lzham_symbol_codec*)@this)->m_arith_length = num2;
			}
			else
			{
				if ((b & 1) == 1)
				{
					int num5 = (ushort)((lzham_adaptive_bit_model*)model)->m_bit_0_prob >> 5;
					short* bit_0_prob2 = &((lzham_adaptive_bit_model*)model)->m_bit_0_prob;
					*bit_0_prob2 = (short)checked(unchecked((ushort)(*bit_0_prob2)) - num5);
				}
				((lzham_symbol_codec*)@this)->m_arith_value -= num2;
				((lzham_symbol_codec*)@this)->m_arith_length -= num2;
			}
			return num3;
		}
	}
}
