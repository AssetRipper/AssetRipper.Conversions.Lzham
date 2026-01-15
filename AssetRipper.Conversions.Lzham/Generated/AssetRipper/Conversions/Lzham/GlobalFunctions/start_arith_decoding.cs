using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?start_arith_decoding@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::start_arith_decoding(void)")]
internal static partial class start_arith_decoding
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_arith_length = -1;
			((lzham_symbol_codec*)@this)->m_arith_value = 0;
			int num = Get_bits.Invoke(@this, 8);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			((lzham_symbol_codec*)@this)->m_arith_value = num << 24;
			int num2 = Get_bits.Invoke(@this, 8);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			((lzham_symbol_codec*)@this)->m_arith_value |= num2 << 16;
			int num3 = Get_bits.Invoke(@this, 8);
			if (ExceptionInfo.Current == null)
			{
				((lzham_symbol_codec*)@this)->m_arith_value |= num3 << 8;
				int num4 = Get_bits.Invoke(@this, 8);
				if (ExceptionInfo.Current == null)
				{
					((lzham_symbol_codec*)@this)->m_arith_value |= num4;
				}
			}
		}
	}
}
