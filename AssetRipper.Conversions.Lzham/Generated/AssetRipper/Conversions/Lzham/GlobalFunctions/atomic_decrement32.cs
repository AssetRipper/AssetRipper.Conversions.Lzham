using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?atomic_decrement32@lzham@@YAJPECJ@Z")]
[DemangledName("long __cdecl lzham::atomic_decrement32(long volatile *)")]
internal static partial class atomic_decrement32
{
	[return: NativeType("long")]
	public unsafe static int Invoke([NativeType("long volatile *")] void* pDest)
	{
		(*unchecked((int*)pDest))--;
		return *unchecked((int*)pDest);
	}
}
