using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_mem_error@lzham@@YAXPEBD@Z")]
[DemangledName("void __cdecl lzham::lzham_mem_error(char const *)")]
internal static partial class lzham_mem_error
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("char const *")] void* p_msg)
	{
		lzham_assert.Invoke(p_msg, String_pfb5rd.__pointer, 140);
	}
}
