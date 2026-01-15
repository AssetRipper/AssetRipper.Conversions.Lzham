using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?ceil_log2i@math@lzham@@YAII@Z")]
[DemangledName("unsigned int __cdecl lzham::math::ceil_log2i(unsigned int)")]
internal static partial class ceil_log2i
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int v)
	{
		int num = floor_log2i.Invoke(v);
		unchecked
		{
			if (num != 32 && (uint)v > (uint)(1 << num))
			{
				num++;
			}
			return num;
		}
	}
}
