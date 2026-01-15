using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$maximum@N@math@lzham@@YANNN@Z")]
[DemangledName("double __cdecl lzham::math::maximum<double>(double, double)")]
[CleanName("maximum")]
internal static partial class maximum_qi5jyn
{
	[return: NativeType("double")]
	public static double Invoke([NativeType("double")] double a, [NativeType("double")] double b)
	{
		return (!(a > b)) ? b : a;
	}
}
