using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?atomic_exchange32@lzham@@YAJPECJJ@Z")]
[DemangledName("long __cdecl lzham::atomic_exchange32(long volatile *, long)")]
internal static partial class atomic_exchange32
{
	[return: NativeType("long")]
	public unsafe static int Invoke([NativeType("long volatile *")] void* pDest, [NativeType("long")] int val)
	{
		unchecked
		{
			int result = *(int*)pDest;
			*(int*)pDest = val;
			return result;
		}
	}
}
