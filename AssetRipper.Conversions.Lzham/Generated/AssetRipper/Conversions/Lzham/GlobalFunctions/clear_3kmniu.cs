using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@adaptive_arith_data_model@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::adaptive_arith_data_model::clear(void)")]
[CleanName("clear")]
internal static partial class clear_3kmniu
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_adaptive_arith_data_model*)@this)->m_total_syms = 0;
			clear_hqamxp.Invoke(&((lzham_adaptive_arith_data_model*)@this)->m_probs);
		}
	}
}
