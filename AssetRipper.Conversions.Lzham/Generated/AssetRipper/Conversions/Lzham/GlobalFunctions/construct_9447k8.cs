using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Vlzcompressor@lzham@@@helpers@lzham@@YAPEAVlzcompressor@1@PEAV21@@Z")]
[DemangledName("class lzham::lzcompressor * __cdecl lzham::helpers::construct<class lzham::lzcompressor>(class lzham::lzcompressor *)")]
[CleanName("construct")]
internal static partial class construct_9447k8
{
	[return: NativeType("class lzham::lzcompressor *")]
	public unsafe static void* Invoke([NativeType("class lzham::lzcompressor *")] void* p)
	{
		lzcompressor_Constructor.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return p;
	}
}
