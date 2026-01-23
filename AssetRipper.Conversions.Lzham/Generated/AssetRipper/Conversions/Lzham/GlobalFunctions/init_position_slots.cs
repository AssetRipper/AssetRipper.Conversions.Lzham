using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init_position_slots@CLZDecompBase@lzham@@QEAAXI@Z")]
[DemangledName("public: void __cdecl lzham::CLZDecompBase::init_position_slots(unsigned int)")]
internal static partial class init_position_slots
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int dict_size_log2)
	{
		unchecked
		{
			((lzham_CLZDecompBase*)@this)->m_cur_ofs = dict_size_log2;
			((lzham_CLZDecompBase*)@this)->m_cur_state = 1 << dict_size_log2;
			((lzham_CLZDecompBase*)@this)->m_match_hist = (byte)((sbyte*)g_num_lzx_position_slots.Pointer)[(uint)(dict_size_log2 - 15)];
		}
	}
}
