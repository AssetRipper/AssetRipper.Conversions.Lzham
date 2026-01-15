using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new_array@I@lzham@@YAPEAII@Z")]
[DemangledName("unsigned int * __cdecl lzham::lzham_new_array<unsigned int>(unsigned int)")]
[CleanName("lzham_new_array")]
internal static partial class lzham_new_array_qrkyp9
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke([NativeType("unsigned int")] int num)
	{
		int num2 = num;
		if (num2 == 0)
		{
			num2 = 1;
		}
		unchecked
		{
			void* ptr = lzham_malloc.Invoke(16L + 4L * (long)(uint)num2, null);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			void* ptr2 = ptr;
			if (ptr2 == null)
			{
				return null;
			}
			void* ptr3 = (byte*)ptr2 + 16;
			*(int*)((byte*)ptr3 + -4) = num2;
			*(int*)((byte*)ptr3 + -8) = num2 ^ -1;
			return ptr3;
		}
	}
}
