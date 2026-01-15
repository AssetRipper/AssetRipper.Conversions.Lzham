using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$minimum@I@math@lzham@@YAIII@Z")]
[DemangledName("unsigned int __cdecl lzham::math::minimum<unsigned int>(unsigned int, unsigned int)")]
[CleanName("minimum")]
internal static partial class minimum_c94n3m
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return unchecked((uint)a >= (uint)b) ? b : a;
	}
}
