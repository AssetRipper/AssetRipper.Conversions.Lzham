using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init_slot_tabs@CLZBase@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::CLZBase::init_slot_tabs(void)")]
internal static partial class init_slot_tabs
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			for (int i = 1; (uint)i < (uint)((lzham_CLZDecompBase*)@this)->m_match_hist; i++)
			{
				compute_lzx_position_slot.Invoke(@this, ((int*)m_lzx_position_base.__pointer)[(uint)i], &num, &num2);
				compute_lzx_position_slot.Invoke(@this, ((int*)m_lzx_position_base.__pointer)[(uint)i] + ((int*)m_lzx_position_extra_mask.__pointer)[(uint)i], &num, &num2);
			}
			for (int j = 1; (uint)j <= (uint)(((lzham_CLZDecompBase*)@this)->m_cur_state - 1); j += 524288)
			{
				compute_lzx_position_slot.Invoke(@this, j, &num, &num2);
			}
			compute_lzx_position_slot.Invoke(@this, ((lzham_CLZDecompBase*)@this)->m_cur_state - 1, &num, &num2);
		}
	}
}
