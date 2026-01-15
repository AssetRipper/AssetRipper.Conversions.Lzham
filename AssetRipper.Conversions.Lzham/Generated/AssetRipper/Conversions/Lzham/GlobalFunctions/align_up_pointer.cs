using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$align_up_pointer@PEAE@math@lzham@@YAPEAEPEAEI@Z")]
[DemangledName("unsigned char * __cdecl lzham::math::align_up_pointer<unsigned char *>(unsigned char *, unsigned int)")]
internal static partial class align_up_pointer
{
	[return: NativeType("unsigned char *")]
	public unsafe static void* Invoke([NativeType("unsigned char *")] void* p, [NativeType("unsigned int")] int alignment)
	{
		return unchecked((void*)(((long)p + (long)(uint)alignment - 1L) & (((long)(uint)alignment - 1L) ^ -1L)));
	}
}
