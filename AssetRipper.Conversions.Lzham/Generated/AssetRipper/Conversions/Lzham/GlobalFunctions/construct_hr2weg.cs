using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Ulzham_decompressor@lzham@@@helpers@lzham@@YAPEAUlzham_decompressor@1@PEAU21@@Z")]
[DemangledName("struct lzham::lzham_decompressor * __cdecl lzham::helpers::construct<struct lzham::lzham_decompressor>(struct lzham::lzham_decompressor *)")]
[CleanName("construct")]
internal static partial class construct_hr2weg
{
	[return: NativeType("struct lzham::lzham_decompressor *")]
	public unsafe static void* Invoke([NativeType("struct lzham::lzham_decompressor *")] void* p)
	{
		lzham_decompressor_Constructor.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return p;
	}
}
