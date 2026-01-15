using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?convert_to_scaled_bitcost@lzham@@YA_KI@Z")]
[DemangledName("unsigned __int64 __cdecl lzham::convert_to_scaled_bitcost(unsigned int)")]
internal static partial class convert_to_scaled_bitcost
{
	[return: NativeType("unsigned __int64")]
	public static long Invoke([NativeType("unsigned int")] int bits)
	{
		return unchecked((uint)(bits << 24));
	}
}
