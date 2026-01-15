using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete_array@I@lzham@@YAXPEAI@Z")]
[DemangledName("void __cdecl lzham::lzham_delete_array<unsigned int>(unsigned int *)")]
[CleanName("lzham_delete_array")]
internal static partial class lzham_delete_array_g5z2nn
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int *")] void* p)
	{
		unchecked
		{
			if (p != null && *(int*)((byte*)p + -4) == (*(int*)((byte*)p + -8) ^ -1))
			{
				lzham_free.Invoke((byte*)p + -16);
				if (ExceptionInfo.Current == null)
				{
				}
			}
		}
	}
}
