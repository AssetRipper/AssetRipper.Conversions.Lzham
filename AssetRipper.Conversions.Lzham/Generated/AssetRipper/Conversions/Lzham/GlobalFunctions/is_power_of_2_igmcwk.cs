using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?is_power_of_2@math@lzham@@YA_NI@Z")]
[DemangledName("bool __cdecl lzham::math::is_power_of_2(unsigned int)")]
[CleanName("is_power_of_2")]
internal static partial class is_power_of_2_igmcwk
{
	[return: NativeType("bool")]
	public static bool Invoke([NativeType("unsigned int")] int x)
	{
		return x != 0 && (x & unchecked(x - 1)) == 0;
	}
}
