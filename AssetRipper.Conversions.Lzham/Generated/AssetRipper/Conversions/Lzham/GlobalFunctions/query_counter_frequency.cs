using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?query_counter_frequency@lzham@@YAXPEA_K@Z")]
[DemangledName("void __cdecl lzham::query_counter_frequency(unsigned __int64 *)")]
internal static partial class query_counter_frequency
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned __int64 *")] void* pTicks)
	{
		*unchecked((long*)pTicks) = 1000L;
	}
}
