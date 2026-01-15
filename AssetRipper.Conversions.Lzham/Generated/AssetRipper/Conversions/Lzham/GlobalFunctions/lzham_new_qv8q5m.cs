using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new@Vdecoder_tables@prefix_coding@lzham@@V123@@lzham@@YAPEAVdecoder_tables@prefix_coding@0@AEBV120@@Z")]
[DemangledName("class lzham::prefix_coding::decoder_tables * __cdecl lzham::lzham_new<class lzham::prefix_coding::decoder_tables, class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables const &)")]
[CleanName("lzham_new")]
internal static partial class lzham_new_qv8q5m
{
	[return: NativeType("class lzham::prefix_coding::decoder_tables *")]
	public unsafe static void* Invoke([NativeType("class lzham::prefix_coding::decoder_tables const &")] void* init0)
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
		void* ptr3 = ptr2;
		decoder_tables_Constructor_dr2jyt.Invoke(ptr3, init0);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return ptr3;
	}
}
