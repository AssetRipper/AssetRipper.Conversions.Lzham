using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?ticks_to_secs@lzham_timer@lzham@@SAN_K@Z")]
[DemangledName("public: static double __cdecl lzham::lzham_timer::ticks_to_secs(unsigned __int64)")]
internal static partial class ticks_to_secs
{
	[return: NativeType("double")]
	public static double Invoke([NativeType("unsigned __int64")] long ticks)
	{
		if (!NumericHelper.IsUnorderedOrNotEquals(g_inv_freq.Value, 0.0))
		{
			init_ptjsy3.Invoke();
		}
		return (double)ticks * g_inv_freq.Value;
	}
}
