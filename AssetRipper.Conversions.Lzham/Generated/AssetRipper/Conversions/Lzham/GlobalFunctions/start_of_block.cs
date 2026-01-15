using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?start_of_block@state@lzcompressor@lzham@@QEAAXAEBVsearch_accelerator@3@II@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::start_of_block(class lzham::search_accelerator const &, unsigned int, unsigned int)")]
internal static partial class start_of_block
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int cur_ofs, [NativeType("unsigned int")] int block_index)
	{
		reset_state_partial.Invoke(@this);
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = cur_ofs;
			((lzham_lzcompressor_state*)@this)->field_1 = cur_ofs;
		}
	}
}
