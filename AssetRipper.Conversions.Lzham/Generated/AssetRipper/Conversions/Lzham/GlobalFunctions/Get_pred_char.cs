using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_pred_char@state@lzcompressor@lzham@@QEBAIAEBVsearch_accelerator@3@HH@Z")]
[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::state::get_pred_char(class lzham::search_accelerator const &, int, int) const")]
internal static partial class Get_pred_char
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("int")] int pos, [NativeType("int")] int backward_ofs)
	{
		if (backward_ofs > unchecked(pos - ((lzham_lzcompressor_state*)@this)->field_1))
		{
			return 0;
		}
		return search_accelerator_Operator.Invoke(dict, pos - backward_ofs);
	}
}
