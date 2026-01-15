using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?put_bits_init@symbol_codec@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::put_bits_init(unsigned int)")]
internal static partial class put_bits_init
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int expected_size)
	{
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_bit_buf = 0L;
			((lzham_symbol_codec*)@this)->m_bit_count = 64;
			try_resize_m9x9dy.Invoke(&((lzham_symbol_codec*)@this)->m_output_buf, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag = try_reserve_cnc229.Invoke(&((lzham_symbol_codec*)@this)->m_output_buf, expected_size);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			return true;
		}
	}
}
