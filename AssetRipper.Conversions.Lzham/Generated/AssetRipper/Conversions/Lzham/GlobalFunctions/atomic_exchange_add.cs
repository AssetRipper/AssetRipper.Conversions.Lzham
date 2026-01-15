using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?atomic_exchange_add@lzham@@YAJPECJJ@Z")]
[DemangledName("long __cdecl lzham::atomic_exchange_add(long volatile *, long)")]
internal static partial class atomic_exchange_add
{
	[return: NativeType("long")]
	public unsafe static int Invoke([NativeType("long volatile *")] void* pDest, [NativeType("long")] int val)
	{
		int result = *unchecked((int*)pDest);
		*unchecked((int*)pDest) += val;
		return result;
	}
}
