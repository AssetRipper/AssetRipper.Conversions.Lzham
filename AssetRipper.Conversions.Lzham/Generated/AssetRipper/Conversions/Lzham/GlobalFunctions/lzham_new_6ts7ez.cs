using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new@Vdecoder_tables@prefix_coding@lzham@@@lzham@@YAPEAVdecoder_tables@prefix_coding@0@XZ")]
[DemangledName("class lzham::prefix_coding::decoder_tables * __cdecl lzham::lzham_new<class lzham::prefix_coding::decoder_tables>(void)")]
[CleanName("lzham_new")]
internal static partial class lzham_new_6ts7ez
{
	[return: NativeType("class lzham::prefix_coding::decoder_tables *")]
	public unsafe static void* Invoke()
	{
		void* ptr = lzham_malloc.Invoke(192L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		return construct_awdxwb.Invoke(ptr2);
	}
}
