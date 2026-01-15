using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?advance_bytes@search_accelerator@lzham@@QEAAXI@Z")]
[DemangledName("public: void __cdecl lzham::search_accelerator::advance_bytes(unsigned int)")]
internal static partial class advance_bytes
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int num_bytes)
	{
		unchecked
		{
			((lzham_search_accelerator*)@this)->m_lookahead_pos += num_bytes;
			((lzham_search_accelerator*)@this)->m_lookahead_size -= num_bytes;
			((lzham_search_accelerator*)@this)->m_cur_dict_size += num_bytes;
		}
	}
}
