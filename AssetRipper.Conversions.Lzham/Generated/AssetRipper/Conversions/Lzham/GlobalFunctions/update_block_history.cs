using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update_block_history@lzcompressor@lzham@@AEAAXIII_N0@Z")]
[DemangledName("private: void __cdecl lzham::lzcompressor::update_block_history(unsigned int, unsigned int, unsigned int, bool, bool)")]
internal static partial class update_block_history
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int comp_size, [NativeType("unsigned int")] int src_size, [NativeType("unsigned int")] int ratio, [NativeType("bool")] bool raw_block, [NativeType("bool")] bool reset_update_rate)
	{
		bool num = reset_update_rate;
		bool num2 = raw_block;
		unchecked
		{
			void* ptr = (byte*)(&((lzham_lzcompressor*)@this)->field_21) + (nint)(uint)((lzham_lzcompressor*)@this)->field_23 * (nint)sizeof(lzham_lzcompressor_block_history);
			((lzham_lzcompressor*)@this)->field_23++;
			int* field_ = &((lzham_lzcompressor*)@this)->field_23;
			*field_ = (int)((uint)(*field_) % 6u);
			((lzham_lzcompressor_block_history*)ptr)->m_comp_size = comp_size;
			((lzham_lzcompressor_block_history*)ptr)->m_src_size = src_size;
			((lzham_lzcompressor_block_history*)ptr)->m_ratio = ratio;
			((lzham_lzcompressor_block_history*)ptr)->m_raw_block = ((((num2 ? 1u : 0u) & 1u) == 1) ? ((sbyte)1) : ((sbyte)0));
			((lzham_lzcompressor_block_history*)ptr)->m_reset_update_rate = ((((num ? 1u : 0u) & 1u) == 1) ? ((sbyte)1) : ((sbyte)0));
			((lzham_lzcompressor*)@this)->field_22 = (((uint)(((lzham_lzcompressor*)@this)->field_22 + 1) >= 6u) ? 6 : (((lzham_lzcompressor*)@this)->field_22 + 1));
		}
	}
}
