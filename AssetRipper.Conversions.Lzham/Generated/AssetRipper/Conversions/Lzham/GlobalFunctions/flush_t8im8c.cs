using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?flush@search_accelerator@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::search_accelerator::flush(void)")]
[CleanName("flush")]
internal static partial class flush_t8im8c
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked((lzham_search_accelerator*)@this)->m_cur_dict_size = 0;
	}
}
