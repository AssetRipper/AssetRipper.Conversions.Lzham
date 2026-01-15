using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete_array@G@lzham@@YAXPEAG@Z")]
[DemangledName("void __cdecl lzham::lzham_delete_array<unsigned short>(unsigned short *)")]
[CleanName("lzham_delete_array")]
internal static partial class lzham_delete_array_i9xite
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned short *")] void* p)
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
