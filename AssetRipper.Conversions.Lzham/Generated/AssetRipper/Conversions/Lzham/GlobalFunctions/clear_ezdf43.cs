using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@adaptive_bit_model@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::adaptive_bit_model::clear(void)")]
[CleanName("clear")]
internal static partial class clear_ezdf43
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked((lzham_adaptive_bit_model*)@this)->m_bit_0_prob = 1024;
	}
}
