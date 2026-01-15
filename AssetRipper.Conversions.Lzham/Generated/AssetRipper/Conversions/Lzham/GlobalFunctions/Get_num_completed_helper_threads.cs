using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_num_completed_helper_threads@search_accelerator@lzham@@QEBAJXZ")]
[DemangledName("public: long __cdecl lzham::search_accelerator::get_num_completed_helper_threads(void) const")]
internal static partial class Get_num_completed_helper_threads
{
	[return: NativeType("long")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_search_accelerator*)@this)->m_num_completed_helper_threads;
	}
}
