using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$maximum@H@math@lzham@@YAHHH@Z")]
[DemangledName("int __cdecl lzham::math::maximum<int>(int, int)")]
[CleanName("maximum")]
internal static partial class maximum_67w4wi
{
	[return: NativeType("int")]
	public static int Invoke([NativeType("int")] int a, [NativeType("int")] int b)
	{
		return (a <= b) ? b : a;
	}
}
