using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?hash3_to_16@lzham@@YAIIII@Z")]
[DemangledName("unsigned int __cdecl lzham::hash3_to_16(unsigned int, unsigned int, unsigned int)")]
internal static partial class hash3_to_16
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int c0, [NativeType("unsigned int")] int c1, [NativeType("unsigned int")] int c2)
	{
		return (c0 | (c1 << 8)) ^ (c2 << 4);
	}
}
