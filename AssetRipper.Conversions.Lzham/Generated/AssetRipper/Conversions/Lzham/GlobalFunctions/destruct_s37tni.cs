using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$destruct@Ulzham_decompressor@lzham@@@helpers@lzham@@YAXPEAUlzham_decompressor@1@@Z")]
[DemangledName("void __cdecl lzham::helpers::destruct<struct lzham::lzham_decompressor>(struct lzham::lzham_decompressor *)")]
[CleanName("destruct")]
internal static partial class destruct_s37tni
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzham_decompressor *")] void* p)
	{
		lzham_decompressor_Destructor.Invoke(p);
	}
}
