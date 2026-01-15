using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete@Vlzcompressor@lzham@@@lzham@@YAXPEAVlzcompressor@0@@Z")]
[DemangledName("void __cdecl lzham::lzham_delete<class lzham::lzcompressor>(class lzham::lzcompressor *)")]
[CleanName("lzham_delete")]
internal static partial class lzham_delete_5e8ypf
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::lzcompressor *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		destruct_ivrhzw.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			lzham_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
