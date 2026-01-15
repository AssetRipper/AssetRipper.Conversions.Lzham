using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?is_power_of_2@math@lzham@@YA_N_K@Z")]
[DemangledName("bool __cdecl lzham::math::is_power_of_2(unsigned __int64)")]
[CleanName("is_power_of_2")]
internal static partial class is_power_of_2_7smfqf
{
	[return: NativeType("bool")]
	public static bool Invoke([NativeType("unsigned __int64")] long x)
	{
		return x != 0L && (x & unchecked(x - 1L)) == 0L;
	}
}
