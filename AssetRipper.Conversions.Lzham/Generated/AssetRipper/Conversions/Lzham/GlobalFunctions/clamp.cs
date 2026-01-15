using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$clamp@I@math@lzham@@YAIIII@Z")]
[DemangledName("unsigned int __cdecl lzham::math::clamp<unsigned int>(unsigned int, unsigned int, unsigned int)")]
internal static partial class clamp
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int value, [NativeType("unsigned int")] int low, [NativeType("unsigned int")] int high)
	{
		return unchecked(((uint)value >= (uint)low) ? (((uint)value <= (uint)high) ? value : high) : low);
	}
}
