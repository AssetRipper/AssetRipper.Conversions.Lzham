using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$maximum@I@math@lzham@@YAIII@Z")]
[DemangledName("unsigned int __cdecl lzham::math::maximum<unsigned int>(unsigned int, unsigned int)")]
[CleanName("maximum")]
internal static partial class maximum_95ffuu
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return unchecked((uint)a <= (uint)b) ? b : a;
	}
}
