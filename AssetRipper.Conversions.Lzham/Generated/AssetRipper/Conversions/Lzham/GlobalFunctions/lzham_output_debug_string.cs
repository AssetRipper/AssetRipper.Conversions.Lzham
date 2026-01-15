using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_output_debug_string@@YAXPEBD@Z")]
[DemangledName("void __cdecl lzham_output_debug_string(char const *)")]
internal static partial class lzham_output_debug_string
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("char const *")] void* p)
	{
		fputs.Invoke(p, acrt_iob_func.Invoke(2));
	}
}
