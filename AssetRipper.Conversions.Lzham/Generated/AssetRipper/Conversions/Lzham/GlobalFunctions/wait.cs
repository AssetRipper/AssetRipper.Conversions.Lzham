using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?wait@semaphore@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::semaphore::wait(unsigned int)")]
internal static partial class wait
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int milliseconds)
	{
		return true;
	}
}
