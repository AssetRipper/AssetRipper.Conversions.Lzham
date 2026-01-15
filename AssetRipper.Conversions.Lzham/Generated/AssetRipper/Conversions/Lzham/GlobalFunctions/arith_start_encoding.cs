using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?arith_start_encoding@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::arith_start_encoding(void)")]
internal static partial class arith_start_encoding
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			try_resize_m9x9dy.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf, 0, grow_hint: false);
			if (ExceptionInfo.Current == null)
			{
				((lzham_symbol_codec*)@this)->m_arith_base = 0;
				((lzham_symbol_codec*)@this)->m_arith_value = 0;
				((lzham_symbol_codec*)@this)->m_arith_length = -1;
				((lzham_symbol_codec*)@this)->m_arith_total_bits = 0;
			}
		}
	}
}
