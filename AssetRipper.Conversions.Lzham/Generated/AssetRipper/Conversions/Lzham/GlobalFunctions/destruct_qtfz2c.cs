using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$destruct@Ulzham_compress_state@lzham@@@helpers@lzham@@YAXPEAUlzham_compress_state@1@@Z")]
[DemangledName("void __cdecl lzham::helpers::destruct<struct lzham::lzham_compress_state>(struct lzham::lzham_compress_state *)")]
[CleanName("destruct")]
internal static partial class destruct_qtfz2c
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzham_compress_state *")] void* p)
	{
		lzham_compress_state_Destructor.Invoke(p);
	}
}
