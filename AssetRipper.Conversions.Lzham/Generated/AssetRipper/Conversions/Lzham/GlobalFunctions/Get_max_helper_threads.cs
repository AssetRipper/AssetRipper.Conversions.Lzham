using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_max_helper_threads@search_accelerator@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_max_helper_threads(void) const")]
internal static partial class Get_max_helper_threads
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_search_accelerator*)@this)->m_max_helper_threads;
	}
}
