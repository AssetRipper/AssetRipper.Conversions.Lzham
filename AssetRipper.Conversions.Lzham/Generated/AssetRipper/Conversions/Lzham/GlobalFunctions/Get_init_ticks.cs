using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_init_ticks@lzham_timer@lzham@@SA_KXZ")]
[DemangledName("public: static unsigned __int64 __cdecl lzham::lzham_timer::get_init_ticks(void)")]
internal static partial class Get_init_ticks
{
	[return: NativeType("unsigned __int64")]
	public static long Invoke()
	{
		if (!NumericHelper.IsUnorderedOrNotEquals(g_inv_freq.Value, 0.0))
		{
			init_ptjsy3.Invoke();
		}
		return g_init_ticks.Value;
	}
}
