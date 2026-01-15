using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode_align_to_byte@symbol_codec@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::symbol_codec::decode_align_to_byte(void)")]
internal static partial class decode_align_to_byte
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if ((((lzham_symbol_codec*)@this)->m_bit_count & 7) != 0)
			{
				remove_bits.Invoke(@this, ((lzham_symbol_codec*)@this)->m_bit_count & 7);
				if (ExceptionInfo.Current == null)
				{
				}
			}
		}
	}
}
