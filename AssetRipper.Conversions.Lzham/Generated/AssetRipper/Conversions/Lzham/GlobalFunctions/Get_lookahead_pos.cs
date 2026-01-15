using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_lookahead_pos@search_accelerator@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_lookahead_pos(void) const")]
internal static partial class Get_lookahead_pos
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((lzham_search_accelerator*)@this)->m_lookahead_pos;
	}
}
