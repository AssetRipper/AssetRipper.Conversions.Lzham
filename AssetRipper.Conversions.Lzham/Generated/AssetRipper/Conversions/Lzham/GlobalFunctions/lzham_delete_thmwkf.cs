using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete@Vdecoder_tables@prefix_coding@lzham@@@lzham@@YAXPEAVdecoder_tables@prefix_coding@0@@Z")]
[DemangledName("void __cdecl lzham::lzham_delete<class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables *)")]
[CleanName("lzham_delete")]
internal static partial class lzham_delete_thmwkf
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::prefix_coding::decoder_tables *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		destruct_np23pw.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			lzham_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
