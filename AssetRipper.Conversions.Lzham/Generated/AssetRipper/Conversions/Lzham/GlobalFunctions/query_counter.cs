using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?query_counter@lzham@@YAXPEA_K@Z")]
[DemangledName("void __cdecl lzham::query_counter(unsigned __int64 *)")]
internal static partial class query_counter
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned __int64 *")] void* pTicks)
	{
		*unchecked((long*)pTicks) = clock.Invoke();
	}
}
