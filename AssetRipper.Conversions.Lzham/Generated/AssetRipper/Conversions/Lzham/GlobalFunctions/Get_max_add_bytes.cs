using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_max_add_bytes@search_accelerator@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_max_add_bytes(void) const")]
internal static partial class Get_max_add_bytes
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		unchecked
		{
			int num = ((lzham_search_accelerator*)@this)->m_lookahead_pos & (((lzham_search_accelerator*)@this)->m_max_dict_size - 1);
			return ((lzham_search_accelerator*)@this)->m_max_dict_size - num;
		}
	}
}
