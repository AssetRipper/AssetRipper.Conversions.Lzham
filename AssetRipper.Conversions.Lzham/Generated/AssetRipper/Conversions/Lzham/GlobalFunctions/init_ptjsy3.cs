using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@lzham_timer@lzham@@SAXXZ")]
[DemangledName("public: static void __cdecl lzham::lzham_timer::init(void)")]
[CleanName("init")]
internal static partial class init_ptjsy3
{
	[return: NativeType("void")]
	public unsafe static void Invoke()
	{
		if (!NumericHelper.IsUnorderedOrNotEquals(g_inv_freq.Value, 0.0))
		{
			query_counter_frequency.Invoke(g_freq.Pointer);
			g_inv_freq.Value = 1f / (float)g_freq.Value;
			query_counter.Invoke(g_init_ticks.Pointer);
		}
	}
}
