using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?compute_lzx_position_slot@CLZBase@lzham@@QEAAXIAEAI0@Z")]
[DemangledName("public: void __cdecl lzham::CLZBase::compute_lzx_position_slot(unsigned int, unsigned int &, unsigned int &)")]
internal static partial class compute_lzx_position_slot
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int dist, [NativeType("unsigned int &")] void* slot, [NativeType("unsigned int &")] void* ofs)
	{
		unchecked
		{
			int num = (((uint)dist >= 4096u) ? (((uint)dist >= 1048576u) ? (((uint)dist >= 16777216u) ? (((uint)dist >= 33554432u) ? (((uint)dist >= 67108864u) ? (52 + (dist - 67108864 >>> 25)) : (50 + (dist - 33554432 >>> 24))) : (48 + (dist - 16777216 >>> 23))) : ((byte)((sbyte*)m_slot_tab2.Pointer)[(uint)(dist >>> 16)])) : ((byte)((sbyte*)m_slot_tab1.Pointer)[(uint)(dist >>> 11)])) : ((byte)((sbyte*)m_slot_tab0.Pointer)[(uint)dist]));
			*(int*)ofs = (dist - ((int*)m_lzx_position_base.Pointer)[(uint)num]) & ((int*)m_lzx_position_extra_mask.Pointer)[(uint)num];
			*(int*)slot = num;
		}
	}
}
