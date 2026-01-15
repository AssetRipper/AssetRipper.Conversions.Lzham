using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_ticks@lzham_timer@lzham@@SA_KXZ")]
[DemangledName("public: static unsigned __int64 __cdecl lzham::lzham_timer::get_ticks(void)")]
internal static partial class Get_ticks
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke()
	{
		long num = 0L;
		if (!NumericHelper.IsUnorderedOrNotEquals(g_inv_freq.Value, 0.0))
		{
			init_ptjsy3.Invoke();
		}
		query_counter.Invoke(&num);
		return unchecked(num - g_init_ticks.Value);
	}
}
