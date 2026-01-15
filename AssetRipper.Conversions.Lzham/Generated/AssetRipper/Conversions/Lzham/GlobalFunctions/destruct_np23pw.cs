using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$destruct@Vdecoder_tables@prefix_coding@lzham@@@helpers@lzham@@YAXPEAVdecoder_tables@prefix_coding@1@@Z")]
[DemangledName("void __cdecl lzham::helpers::destruct<class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables *)")]
[CleanName("destruct")]
internal static partial class destruct_np23pw
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::prefix_coding::decoder_tables *")] void* p)
	{
		decoder_tables_Destructor.Invoke(p);
	}
}
