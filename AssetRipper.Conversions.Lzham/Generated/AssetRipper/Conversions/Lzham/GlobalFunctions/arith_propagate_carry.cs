using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?arith_propagate_carry@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::arith_propagate_carry(void)")]
internal static partial class arith_propagate_carry
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			int num = size_s5xcpk.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf) - 1;
			while (true)
			{
				if (num < 0)
				{
					return;
				}
				if ((byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, num)) != byte.MaxValue)
				{
					break;
				}
				*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, num) = 0;
				num = checked(num + -1);
			}
			(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, num))++;
		}
	}
}
