using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$minimum@H@math@lzham@@YAHHH@Z")]
[DemangledName("int __cdecl lzham::math::minimum<int>(int, int)")]
[CleanName("minimum")]
internal static partial class minimum_y7839s
{
	[return: NativeType("int")]
	public static int Invoke([NativeType("int")] int a, [NativeType("int")] int b)
	{
		return (a >= b) ? b : a;
	}
}
