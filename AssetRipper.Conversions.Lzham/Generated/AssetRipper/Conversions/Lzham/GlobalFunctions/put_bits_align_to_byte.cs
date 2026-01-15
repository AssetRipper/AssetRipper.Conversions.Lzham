using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?put_bits_align_to_byte@symbol_codec@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::put_bits_align_to_byte(void)")]
internal static partial class put_bits_align_to_byte
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		int num = 64 - unchecked((lzham_symbol_codec*)@this)->m_bit_count;
		if ((num & 7) != 0)
		{
			bool flag = put_bits.Invoke(@this, 0, unchecked(8 - (num & 7)));
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}
}
