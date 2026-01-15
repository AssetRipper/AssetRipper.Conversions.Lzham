using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?hash2_to_12@lzham@@YAIII@Z")]
[DemangledName("unsigned int __cdecl lzham::hash2_to_12(unsigned int, unsigned int)")]
internal static partial class hash2_to_12
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int c0, [NativeType("unsigned int")] int c1)
	{
		return c0 ^ (c1 << 4);
	}
}
