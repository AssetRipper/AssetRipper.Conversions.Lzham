using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$destruct@Vlzcompressor@lzham@@@helpers@lzham@@YAXPEAVlzcompressor@1@@Z")]
[DemangledName("void __cdecl lzham::helpers::destruct<class lzham::lzcompressor>(class lzham::lzcompressor *)")]
[CleanName("destruct")]
internal static partial class destruct_ivrhzw
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::lzcompressor *")] void* p)
	{
		lzcompressor_Destructor.Invoke(p);
	}
}
