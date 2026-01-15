using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?next_pow2@math@lzham@@YAII@Z")]
[DemangledName("unsigned int __cdecl lzham::math::next_pow2(unsigned int)")]
[CleanName("next_pow2")]
internal static partial class next_pow2_sz9rvk
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int val)
	{
		unchecked
		{
			int num = val + -1;
			num |= num >>> 16;
			num |= num >>> 8;
			num |= num >>> 4;
			num |= num >>> 2;
			return (num | (num >>> 1)) + 1;
		}
	}
}
