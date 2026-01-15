using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::clear(void)")]
[CleanName("clear")]
internal static partial class clear_sksy5s
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		reset_jag9x3.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return;
		}
		unchecked
		{
			clear_tzajca.Invoke(&((lzham_symbol_codec*)@this)->m_output_buf);
			if (ExceptionInfo.Current == null)
			{
				clear_tzajca.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf);
				if (ExceptionInfo.Current == null)
				{
					clear_rvrac9.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms);
				}
			}
		}
	}
}
