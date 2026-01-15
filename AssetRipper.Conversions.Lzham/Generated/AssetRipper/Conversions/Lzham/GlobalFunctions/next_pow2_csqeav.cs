using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?next_pow2@math@lzham@@YA_K_K@Z")]
[DemangledName("unsigned __int64 __cdecl lzham::math::next_pow2(unsigned __int64)")]
[CleanName("next_pow2")]
internal static partial class next_pow2_csqeav
{
	[return: NativeType("unsigned __int64")]
	public static long Invoke([NativeType("unsigned __int64")] long val)
	{
		unchecked
		{
			long num = val + -1L;
			num |= num >>> 32;
			num |= num >>> 16;
			num |= num >>> 8;
			num |= num >>> 4;
			num |= num >>> 2;
			return (num | (num >>> 1)) + 1L;
		}
	}
}
